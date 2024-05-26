using jwt.Model;

namespace jwt.Services
{
    public class LoginService
    {
        public IResult LoginResult(User user)
        {
            if (Login(user))
                return Results.Ok("Alll right");
            else
                return Results.Unauthorized();
        }

        private bool Login(User user)
        {
            if (user.Username == "pedro" && user.Password == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
