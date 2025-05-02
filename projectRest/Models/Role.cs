
namespace projectRest.Models
{
    public partial class Role
    {
        public virtual ICollection<Admin> admen_login { get; set; }

        public Role() => this.admen_login = new HashSet<Admin>();
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }

    }
}
