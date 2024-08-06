
using offimed.tools.contracts;
using System.Runtime.Serialization;

namespace RestApiTest.Models.Data
{
    [Serializable, DataContract]
    public class Utilisateur : DefaultAbstractClass4DBAccess
    {
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string Niss { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Ville { get; set; }

        public Utilisateur(int userId, string niss, string userName, string userCity)
        {
            this.UserId = userId;
            Niss = niss;
            UserName = userName;
            Ville = userCity;
        }

        public Utilisateur()
        {
            UserId = 0;
            Niss = string.Empty;
            UserName = string.Empty;
            Ville = string.Empty;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Utilisateur);
        }

        public bool Equals(Utilisateur? other)
        {
            return other is not null &&
                   Niss == other.Niss &&
                   UserName == other.UserName &&
                   Ville == other.Ville;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
