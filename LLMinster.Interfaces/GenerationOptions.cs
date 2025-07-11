using System.Collections.Generic;

namespace LLMinster.Interfaces
{
    public record GenerationOptions
    {
        /// <summary>
        /// Determines which model will be used in the request.
        /// </summary>
        public string Model { get; set; } = string.Empty;
        
        /// <summary>
        /// The list of messages that will be sent to the model.
        /// </summary>
        public IList<Message> Messages { get; set; } = new List<Message>();
        
        /// <summary>
        /// Controls the randomness of the output. Lower values make the output more deterministic.
        /// </summary>
        public float Temperature { get; set; } = 0.025f;

        /// <summary>
        /// The maximum number of tokens to generate.
        /// </summary>
        public int MaxTokens { get; set; } = 4096;
    }
}