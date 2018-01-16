using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PartsLib
{
    public class Category
    {
        public string id;
        public string type;
        public Category parent;
        public List<Category> children;
        public string categoryPath;
        public bool expanded;
        public string name;
        public string description;
    }

    public class PartUnit
    {
        public string id;
        public string type;
        public string name;
        public string shortName;
        public bool @default;
    }

    public class StorageLocation
    {
        public string id;
        public string type;
        public string name;
        public object image;
        public Category category;
        public string categoryPath;
    }

    public class Manufacturer2
    {
        public string id;
        public string type;
        public string name;
        public string address;
        public string url;
        public string email;
        public string comment;
        public string phone;
        public string fax;
        public List<object> icLogos;
    }

    public class Manufacturer
    {
        public string id;
        public string type;
        public Manufacturer2 manufacturer;
        public string partNumber;
    }

    public class Distributor2
    {
        public string id;
        public string type;
        public string name;
        public string address;
        public string url;
        public string phone;
        public string fax;
        public string email;
        public string comment;
        public string skuurl;
        public bool enabledForReports;
    }

    public class Distributor
    {
        public string id;
        public string type;
        public Distributor2 distributor;
        public string orderNumber;
        public int packagingUnit;
        public string price;
        public string currency;
        public string sku;
        public bool ignoreForReports;
    }

    public class Attachment
    {
        public string id;
        public string type;
        public bool isImage;
        public string filename;
        public string originalFilename;
        public string mimetype;
        public int size;
        public string extension;
        public string description;
        public object replacement;
    }

    public class Prefix
    {
        public string id;
        public string type;
        public string prefix;
        public string symbol;
        public int exponent;
        public int @base;
    }

    public class Unit
    {
        public string id;
        public string type;
        public string name;
        public string symbol;
        public List<Prefix> prefixes;
    }

    public class SiPrefix
    {
        public string id;
        public string type;
        public string prefix;
        public string symbol;
        public int exponent;
        public int @base;
    }

    public class Parameter
    {
        public string id;
        public string type;
        public string name;
        public string description;
        public Unit unit;
        public double? value;
        public double? maxValue;
        public double? minValue;
        public string stringValue;
        public string valueType;
        public SiPrefix siPrefix;
        public SiPrefix minSiPrefix;
        public SiPrefix maxSiPrefix;
    }

    public class Footprint
    {
        public string id;
        public string type;
        public string name;
        public string description;
        public Category category;
        public Attachment image;
        public List<Attachment> attachments;
        public string categoryPath;
    }

    public class Parts
    {
        public string context;
        public string id;
        public string type;
        public Category category;
        public string name;
        public string description;
        public Footprint footprint;
        public PartUnit partUnit;
        public StorageLocation storageLocation;
        public List<Manufacturer> manufacturers;
        public List<Distributor> distributors;
        public List<Attachment> attachments;
        public string comment;
        public int stockLevel;
        public int minStockLevel;
        public string averagePrice;
        public List<Parameter> parameters;
        public List<object> metaPartParameterCriterias;
        public string status;
        public bool needsReview;
        public string partCondition;
        public object productionRemarks;
        public DateTime createDate;
        public string internalPartNumber;
        public bool removals;
        public bool lowStock;
        public bool metaPart;
        public object metaPartMatches;
        public string categoryPath;
        public List<string> projectNames;
    }
}
