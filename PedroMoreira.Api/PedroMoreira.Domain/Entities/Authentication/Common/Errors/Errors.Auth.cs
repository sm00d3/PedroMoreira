using ErrorOr;

namespace PedroMoreira.Domain.Authentication.Common.Errors
{
    public static partial class Errors
    {
        public static class Authentication
        {
            public static Error UnauthorizedToken =>
                Error.Forbidden(
                    "Authentication.UnauthorizedToken", 
                    "Invalid Token.");

            public static Error InvalidEmail => 
                Error.Validation(
                    "Authentication.InvalidEmail", 
                    "This email is either invalid or already in use.");

            public static Error InvalidCredentials =>
                Error.Validation(
                    "Authentication.InvalidCredentials",
                    "Authentication failed. Please check your credentials and try again."
                );

            public static Error EmailNotConfirmed =>
                Error.Conflict(
                    "Authentication.EmailNotConfirmed",
                    "Please verify your email address to proceed.");
        }
    }
}
