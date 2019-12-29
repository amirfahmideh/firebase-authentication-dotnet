﻿using System.Threading.Tasks;

namespace Firebase.Auth.UI
{
    /// <summary>
    /// Represents a platform specific UI flow for Firebase authentication. 
    /// </summary>
    public interface IFirebaseUIFlow
    {
        /// <summary>
        /// Reset the flow to the initiali login UI.
        /// </summary>
        void Reset();

        /// <summary>
        /// Do an external sign in in webview / browser. 
        /// </summary>
        Task<User> SignInExternallyAsync(FirebaseProviderType providerType);

        /// <summary>
        /// Get user's email. Used to determine if the user exists or not.
        /// </summary>
        Task<string> PromptForEmailAsync(string error = "");

        /// <summary>
        /// Get user's details. Used to create a new user via email.
        /// </summary>
        /// <param name="email"> Email the user entered in previous step. </param>
        /// <param name="error"> Error encountered in previous attempt. </param>
        Task<EmailUser> PromptForEmailPasswordNameAsync(string email, string error = "");

        /// <summary>
        /// Get user's password. Used to sign in an existing user via email.
        /// </summary>
        /// <param name="email"> Email the user entered in the previous step. </param>
        /// <param name="error"> Error encountered in previous attempt. </param>
        Task<EmailPasswordResult> PromptForPasswordAsync(string email, string error = "");

        /// <summary>
        /// Ask user to confirm email password reset.
        /// </summary>
        /// <param name="email"> Email the user entered in the previous step. </param>
        /// <param name="error"> Error encountered in previous attempt. </param>
        Task<object> PromptForPasswordResetAsync(string email, string error = "");

        /// <summary>
        /// Show user a message that password reset email has been sent.
        /// </summary>
        /// <param name="email"> Email where the reset message has been sent to. </param>
        Task ShowPasswordResetConfirmationAsync(string email);
    }
}
