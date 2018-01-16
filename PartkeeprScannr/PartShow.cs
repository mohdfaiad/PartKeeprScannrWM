using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using CodeBetter.Json;
using PartsLib;
using Symbol;
using Symbol.Barcode;
using Microsoft.Win32;

namespace PartkeeprScannr
{


    public partial class PartShow : Form
    {
        private string userUsername = "";
        private string userPassword = "";
        private string server = "";
        private Symbol.Barcode.Reader myReader = null;
        private Symbol.Barcode.ReaderData myReaderData = null;


   




        public PartShow()
        {
            InitializeComponent();
        }


        public String request (Uri uri, String user, String password )
        {
            //Uri uri = new Uri("http://192.168.2.102/api/parts/79");

            WebRequest request = WebRequest.Create(uri);
            string authInfo = user + ":" + password;
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            request.Timeout = 5000;
            request.Headers["Authorization"] = "Basic " + authInfo;
            try
            {
                WebResponse response = request.GetResponse();
                Stream resStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(resStream);
                String text = reader.ReadToEnd();

                response.Close();
                resStream.Close();
                resStream.Dispose();
                reader.Close();
                reader.Dispose();
                return text;
            }
            catch (WebException e)
            {
                Console.WriteLine("\r\nWebException Raised. The following error occured : " + e.Status);
               // MessageBox.Show("\r\nWebException Raised. The following error occured : "+ e.Status);
            }
            catch (Exception e)
            {
                MessageBox.Show("\nThe following Exception was raised : " + e.Message);

            }
            return "";

           
        }
        public String requestPUT(Uri uri, String user, String password, String putData)
        {
           
            WebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            string authInfo = user + ":" + password;
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            request.Timeout = 10000;
            request.Headers["Authorization"] = "Basic " + authInfo;
            request.Method = "PUT";
            byte[] byteArray = Encoding.UTF8.GetBytes(putData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            
            try
            {
                using (System.IO.Stream sendStream = request.GetRequestStream())
                {
                    sendStream.Write(byteArray, 0, byteArray.Length);
                    sendStream.Close();

                }
               
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                string status;


                if (response.StatusCode == HttpStatusCode.OK)
                    status = "ok";
                else
                    status = "error";
                response.Close();

                return status;
            }
            catch (WebException e)
            {
                Console.WriteLine("\r\nWebException Raised. The following error occured : " + e.Status);
                //MessageBox.Show("\r\nWebException Raised. The following error occured : "+ e);
            }
            catch (Exception e)
            {
                MessageBox.Show("\nThe following Exception was raised : " + e.Message);

            }
            return "";


        }


        private void getPart(string id)
        {

            partName.Text = "Wait...";
            part_description.Text = "";
            avgPrice.Text = "0.00";
            partStock.Text = "0";
            partLocation.Text = "";

           
            string json = request(new Uri(server + "/api/parts/" + id), userUsername, userPassword);
            if (json != "")
            {
                json = json.Replace("@", "");
                Parts part = Converter.Deserialize<Parts>(json);

                partName.Text = part.name;
                part_description.Text = part.description;
                avgPrice.Text = part.averagePrice;
                partStock.Text = Convert.ToString(part.stockLevel);
                partLocation.Text = part.storageLocation.name;

            }
            else
            {
                partName.Text = "Not Found!";
                part_description.Text = "";
                avgPrice.Text = "0.00";
                partStock.Text = "0";
                partLocation.Text = "";

            }


            

        }


        private void readBarcode_Click(object sender, EventArgs e)
        {
            getPart(partID.Text);
        }

        private void PartShow_Load(object sender, EventArgs e)
        {
            loadRegVals();

            myReader = new Symbol.Barcode.Reader();
            myReaderData = new Symbol.Barcode.ReaderData(Symbol.Barcode.ReaderDataTypes.Text, 7905);
            myReader.Actions.Enable();
            myReader.ReadNotify += new EventHandler(myReader_ReadNotify);
            myReader.Actions.Read(myReaderData);
                        
        }

        private void PartShow_Closing(object sender, CancelEventArgs e)
        {
            myReader.Actions.Flush();
            myReaderData.Dispose();

        }
        void myReader_ReadNotify(object sender, EventArgs e)
        {
            Symbol.Barcode.ReaderData nextReaderData = myReader.GetNextReaderData();
            partID.Text = nextReaderData.Text;
            getPart(nextReaderData.Text);
            myReader.Actions.Read(myReaderData);
        }

        private void ConfigMenu_Click(object sender, EventArgs e)
        {
            Config configWindows = new Config();
            configWindows.ShowDialog();
            loadRegVals();
            
        }

        private void loadRegVals()
        {

            Registry.CurrentUser.CreateSubKey("Software\\PartkeeprScannr");

            userUsername = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\PartkeeprScannr", "username", "admin");
            userPassword = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\PartkeeprScannr", "password", "admin");
            server = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\PartkeeprScannr", "server", "https://demo.partkeepr.org");

            

            Registry.SetValue("HKEY_CURRENT_USER\\Software\\PartkeeprScannr", "password", userPassword, RegistryValueKind.ExpandString);

            Registry.SetValue("HKEY_CURRENT_USER\\Software\\PartkeeprScannr", "username", userUsername, RegistryValueKind.ExpandString);

            Registry.SetValue("HKEY_CURRENT_USER\\Software\\PartkeeprScannr", "server", server, RegistryValueKind.ExpandString);
           


        }

        private void Exitmenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partsAdd_Click(object sender, EventArgs e)
        {
            requestPUT(new Uri(server + "/api/parts/" + partID.Text+ "/addStock"), userUsername, userPassword, "quantity=1&price="+ avgPrice.Text +"&comment=");
            getPart(partID.Text);
        }

        private void partsRemove_Click(object sender, EventArgs e)
        {
            requestPUT(new Uri(server + "/api/parts/" + partID.Text + "/addStock"), userUsername, userPassword, "quantity=-1&price=" + avgPrice.Text + "&comment=");
            getPart(partID.Text);
        }

        private void partID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getPart(partID.Text);
            }

        }


 



    }
   



}