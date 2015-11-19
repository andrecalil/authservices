using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IdentityModel.Configuration;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentor.AuthServices.Configuration
{
    /// <summary>
    /// Root interface for the options objects, handling all configuration of
    /// AuthServices.
    /// </summary>
    public interface IOptions
    {
        /// <summary>
        /// Options for the service provider's behaviour; i.e. everything except
        /// the idp and federation list.
        /// </summary>
        ISPOptions SPOptions { get; }

        /// <summary>
        /// Information about known identity providers.
        /// </summary>
        IdentityProviderDictionary IdentityProviders { get; }

        /// <summary>
        /// IdP Public Key to Validate incoming Responses
        /// </summary>
        System.Security.Cryptography.X509Certificates.X509Certificate2 IdpPublicKey { get; set; }

        /// <summary>
        /// Use the public key set in options instead of keys from IdP
        /// </summary>
        bool ValidateUsingPublicKey { get; set; }
    }
}
