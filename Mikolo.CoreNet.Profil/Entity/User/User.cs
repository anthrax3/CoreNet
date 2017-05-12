using System;

namespace Mikolo.CoreNet.Profil.Entity.User
{
    public class User
    {
        private Guid UserId;

        private string UserLastName { get; set; }

        private string UserFirstName { get; set; }

        private string UserName { get; set; }

        private string UserPassword { get; set; }

        private string UserEmail { get; set; }

        private string UserAvatar { get; set; }

        private DateTime DateOfBirth { get; set; }

        private DateTime CreatedOn { get; set; }

        private DateTime UpdatedOn { get; set; }
    }
}
