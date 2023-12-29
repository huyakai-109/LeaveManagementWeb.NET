namespace LeaveManagementWeb.NET.Data
{
    //this base class just means these are standard things that everybody's can inherit from
    //I also generally make this a abstract class because I don't want anybody to be able to instantiate the base entity by itself. You can't do this by itself.
    //It has to have an inheritance working with it.
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
