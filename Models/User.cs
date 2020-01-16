using Programatica.Framework.Data.Models;

namespace Programatica.DummyApp.Mvc.Models
{
    public class User : BaseModel, IModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
