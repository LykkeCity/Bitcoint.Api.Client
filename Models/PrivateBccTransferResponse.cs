// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Bitcoint.Api.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PrivateBccTransferResponse
    {
        /// <summary>
        /// Initializes a new instance of the PrivateBccTransferResponse class.
        /// </summary>
        public PrivateBccTransferResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateBccTransferResponse class.
        /// </summary>
        public PrivateBccTransferResponse(string transaction = default(string), string outputs = default(string))
        {
            Transaction = transaction;
            Outputs = outputs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transaction")]
        public string Transaction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public string Outputs { get; set; }

    }
}