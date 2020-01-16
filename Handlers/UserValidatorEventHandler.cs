using Programatica.DummyApp.Mvc.Models;
using Programatica.Framework.Services.Handlers;

namespace Programatica.DummyApp.Mvc.Handlers
{
    public class UserValidatorEventHandler : IEventHandler<User>
    {

        public UserValidatorEventHandler()
        {
            System.Diagnostics.Debug.WriteLine("UserValidatorEventHandler ctor");
        }

        public void OnAfterCreated(User model)
        {
            System.Diagnostics.Debug.WriteLine("OnAfterCreated");
        }

        public void OnAfterDeleted(User model)
        {
            System.Diagnostics.Debug.WriteLine("OnAfterDeleted");
        }

        public void OnAfterDestroyed(User model)
        {
            System.Diagnostics.Debug.WriteLine("OnAfterDestroyed");
        }

        public void OnAfterModified(User model)
        {
            System.Diagnostics.Debug.WriteLine("OnAfterModified");
        }

        public void OnBeforeCreating(User model)
        {
            System.Diagnostics.Debug.WriteLine("OnBeforeCreating");
        }

        public void OnBeforeDeleting(User model)
        {
            System.Diagnostics.Debug.WriteLine("OnBeforeDeleting");
        }

        public void OnBeforeDestroying(User model)
        {
            System.Diagnostics.Debug.WriteLine("OnBeforeDestroying");
        }

        public void OnBeforeInspecting(User model)
        {
            System.Diagnostics.Debug.WriteLine("OnBeforeInspecting");
        }

        public void OnBeforeModifying(User model)
        {
            System.Diagnostics.Debug.WriteLine("OnBeforeModifying");
        }

    }
}
