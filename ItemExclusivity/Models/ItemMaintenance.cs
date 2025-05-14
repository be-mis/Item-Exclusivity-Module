namespace ItemExclusivity.Models
{
    public class ItemMaintenance
    {
        public int Id { get; set; }
        public string barCode { get; set; }
        public string itemNo { get; set; }
        public string itemDescription { get; set; }
        public string SubDepartment { get; set; }
        public string Size { get; set; }
        public string ChildColor { get; set; }
        public string brandNames { get; set; }
        public int Quantity { get; set; }
        public bool IsSelected { get; set; } = true;
        public string vChainA { get; set; }
        public string vChainB { get; set; }
        public string vChainC { get; set; }
        public string vChainD { get; set; }
        public string vChainE { get; set; }
        public string smA { get; set; }
        public string smB { get; set; }
        public string smC { get; set; }
        public string smD { get; set; }
        public string smE { get; set; }
        public string oHomeA { get; set; }
        public string oHomeB { get; set; }
        public string oHomeC { get; set; }
        public string oHomeD { get; set; }
        public string oHomeE { get; set; }

        public string classification { get; set; }
        public string branchCode { get; set; }
        public string branchName { get; set; }
        public string Brands { get; set; }
        public string classRep { get; set; }
        public string ItemSearchText { get; set; }
        public string ItemValue { get; set; }
        public List<ItemMaintenance> FilteredItems { get; set; } = new List<ItemMaintenance>();

    }
    public class BranchMaintenance
    {
        public string chainCode { get; set; }
        public string company { get; set; }
        public string branchCode { get; set; }
        public string brands { get; set; }

        public string branchName { get; set; }
        public string status { get; set; }
        public string variousChain { get; set; }
        public string epcCampaignChain { get; set; }
        public string storeName { get; set; }
        public bool IsSelected { get; set; } = true;
        public string framesClassification { get; set; }
        public string decorClassification { get; set; }
        public string lampsClassification { get; set; }
        public string clocksClassification { get; set; }
        public string stationeryClassification { get; set; }
        public string classification { get; set; }
        public string StoreClass { get; set; }
        public string ItemSearchText { get; set; }
        public string ItemValue { get; set; }
        public List<ItemMaintenance> FilteredItems { get; set; } = new List<ItemMaintenance>();

    }
    public class StoreClassification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string classId { get; set; }
        public string classRep { get; set; }

    }
    public class Campaign
    {
        public string branchCode { get; set; }
        public string branchName { get; set; }
    }
    public class VariousChain
    {
        public string chain { get; set; }
    }
    public class TransferOrder
    {
        public string CardCode { get; set; }
        public string TransferType { get; set; }
        public string SourceWarehouse { get; set; }
        public string TargetWarehouse { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
    }
    public class ExceptionItem
    {
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public List<string> Items { get; set; } = new List<string>();
        public bool IsEditing { get; set; }
        public ExceptionItem()
        {
            Items = new List<string>();
        }
    }
    public class NewItemMaintenance
    {
        public string Itemno { get; set; }
        public string Itemdescription { get; set; }
        public int quantity { get; set; }

    }
    public class getbranch
    {
        public string branchName { get; set; }
    }
    public class tempAdd
    {
        public string SelectedChain { get; set; }
        public string SelectedBrand { get; set; }
        public string SelectedClass { get; set; }
        public string SelectedBranch { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
    }
    public class BrandClassification
    {
        public int Id { get; set; }
        public string brands { get; set; }
    }
    public class tempExclude
    {
        public string BranchCode { get; set; }
        public string itemexclude { get; set; }
    }
    public class ItemExMaintenance
    {
        public int Id { get; set; }
        public string ItemNo { get; set; }
        public string ItemDescription { get; set; }
        public string Size { get; set; }
        public string ChildColor { get; set; }
        public string brandNames { get; set; }
        public string active {  get; set; }

    }
    public class ExclusivityLogs
    {
        public int Id { get; set; }
        public string selectedChain { get; set; }
        public string selectedCategory { get; set; }
        public string selectedStoreClass { get; set; }
        public string selectedType { get; set; }
        public string branchCode { get; set; }
        public string itemNo { get; set; }
        public int exceptedId { get; set; }
    }
    public class BrandBranch
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string? Company { get; set; }
        public string? ChainCode { get; set; }
        public string? BranchName { get; set; }
    }
}
