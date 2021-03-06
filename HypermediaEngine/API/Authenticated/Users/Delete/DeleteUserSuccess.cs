using Nancy;
using Siren;

namespace HypermediaEngine.API.Authenticated.Users.Delete
{
    public class DeleteUserSuccess : Entity
    {
        public DeleteUserSuccess(NancyContext context) : base(context.Request.Url.ToString(), new [] { "delete", "success" })
        {
        }
    }
}