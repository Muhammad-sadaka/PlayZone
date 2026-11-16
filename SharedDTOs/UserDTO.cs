using System.ComponentModel.DataAnnotations.Schema;

namespace SharedDTOs
{
    public class UserDTO
    {
        [Column("User ID")]
        public int? UserID { set; get; }

        [Column("Username")]
        public string Username { set; get; }

        [Column("Password Hash")]
        public string PasswordHash { set; get; }

        [Column("RoleID")]
        public int RoleID { set; get; }

        [Column("IsActive")]
        public bool IsActive { set; get; }

        public UserDTO(int? userID, string username, string passwordHash, int roleID, bool isActive)
        {
            UserID = userID;
            Username = username;
            PasswordHash = passwordHash;
            RoleID = roleID;
            IsActive = isActive;
        }
    }
}