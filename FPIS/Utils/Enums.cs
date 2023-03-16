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
        NO_USERNAME,
        /// <summary>
        /// User didn't provide any password
        /// </summary>
        NO_PASSWORD,
        /// <summary>
        /// User's login credentials not found
        /// </summary>
        AUTH_FAIL,
        /// <summary>
        /// User successfully connected to the system
        /// </summary>
        AUTH_PASS
    }

    public enum DateFormat
    {
        DATE_ONLY,
        TIME_ONLY,
        DATE_AND_TIME
    }
}
