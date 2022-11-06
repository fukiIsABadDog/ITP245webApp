﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP245_Model
{
    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category
    {
        private sealed class CategoryMetaData
        {
            [Display(Name = "Type")]
            public string Name { get; set; }

        }
    }

    [MetadataType(typeof(ItemMetaData))]
    public partial class Item
    {
        private sealed class ItemMetaData
        {
            [Display(Name ="Title")]
            public string Name { get; set; }

            [Display(Name ="Quantity on Hand")]
            public int QuantityOnHand { get; set; }

            [Display(Name = "Retail Price")]
            [DisplayFormat(DataFormatString = "{0:C}")]
            public decimal RetailPrice { get; set; }

            [Display(Name = "Standard Cost")]
            [DisplayFormat(DataFormatString = "{0:C}")]
            public decimal StandardCost { get; set; }

        }
    }
    [MetadataType(typeof(PoItemMetaData))]
    public partial class PoItem
    {
        private sealed class PoItemMetaData
        {
            [DisplayFormat(DataFormatString = "{0:C}")]
            public decimal Price { get; set; }

            [Display(Name ="Purchase Order Number")]
            public int PurchaseOrderNumber { get; set; }
        }
    }
    [MetadataType(typeof(PurchaseOrderMetaData))]
    public partial class PurchaseOrder
    {
        private sealed class PurchaseOrderMetaData
        {
            [Display(Name="Date")]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
            public System.DateTime PoDate { get; set; }

            [Display(Name ="PO Number")]
            public int PurchaseOrderNumber { get; set; }

            [DisplayFormat(DataFormatString = "{0:C}")]
            public decimal Amount { get; set; }


        }
    }
    [MetadataType(typeof(ReceiptMetaData))]
    public partial class Receipt
    {
        private sealed class ReceiptMetaData
        {

            [Display(Name = "Date")]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
            public int ReceiptDate { get; set; }


            [DisplayFormat(DataFormatString = "{0:C}")]

            public decimal Amount { get; set; }

        }
    }
    [MetadataType(typeof(SpoilageMetaData))]
    public partial class Spoilage
    {
        private sealed class SpoilageMetaData
        {
            [Display(Name ="Reason Type" )]
            public int ReasonType { get; set; }

            [Display(Name = "Date of Occurrence")]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
            public System.DateTime SpoilageDate { get; set; }

            [DisplayFormat(DataFormatString = "{0:C}")]
            public decimal Value { get; set; }

        }
    }
    [MetadataType(typeof(VendorMetaData))]
    public partial class Vendor
    {
        private sealed class VendorMetaData
        {
            [Display(Name = "Vendor Name")]
            public string Name { get; set; }
        }
}
}
