namespace FPIS.Utils
{
    // NOTE: This Enums source code file can be used to store all the flags we will use in this codebase
    
    /// <summary>
    /// Custom enum to indicate the different states during login authentication
    /// </summary>
    public enum LoginAuth
    {
        /// <summary>
        /// User didn't provide a username
        /// </summary>
        NOUSERNAME,
        /// <summary>
        /// User didn't provide any password
        /// </summary>
        NOPASSWORD,
        /// <summary>
        /// User's login credentials not found
        /// </summary>
        AUTHFAIL,
        /// <summary>
        /// User successfully connected to the system
        /// </summary>
        AUTHPASS
    }
}
