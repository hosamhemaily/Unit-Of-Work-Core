using System;
using System.Collections.Generic;

namespace UOW.DAL.Models
{
    public partial class Users
    {
        public Users()
        {
            Jobs = new HashSet<Jobs>();
            NotificationsFromUser = new HashSet<Notifications>();
            NotificationsToUser = new HashSet<Notifications>();
            ServiceSessions = new HashSet<ServiceSessions>();
            UserClaims = new HashSet<UserClaims>();
            UserContentGroups = new HashSet<UserContentGroups>();
            UserLogins = new HashSet<UserLogins>();
            UserProfiles = new HashSet<UserProfiles>();
            UserRoles = new HashSet<UserRoles>();
            UserTokens = new HashSet<UserTokens>();
        }

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public long AccountId { get; set; }
        public long OfficeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName1 { get; set; }
        public string MiddleName2 { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public Guid? SupervisorId { get; set; }
        public long? AvatarMediaFileId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual MediaFiles AvatarMediaFile { get; set; }
        public virtual Offices Office { get; set; }
        public virtual ICollection<Jobs> Jobs { get; set; }
        public virtual ICollection<Notifications> NotificationsFromUser { get; set; }
        public virtual ICollection<Notifications> NotificationsToUser { get; set; }
        public virtual ICollection<ServiceSessions> ServiceSessions { get; set; }
        public virtual ICollection<UserClaims> UserClaims { get; set; }
        public virtual ICollection<UserContentGroups> UserContentGroups { get; set; }
        public virtual ICollection<UserLogins> UserLogins { get; set; }
        public virtual ICollection<UserProfiles> UserProfiles { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
        public virtual ICollection<UserTokens> UserTokens { get; set; }
    }
}
