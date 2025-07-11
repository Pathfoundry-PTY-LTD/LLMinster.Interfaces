using System.Collections.Generic;

namespace LLMinster.Interfaces
{
    public class GenerationOptions
    {
        /// <summary>
        /// The name of the model to be used
        /// </summary>
        public string ModelName { get; set; } = string.Empty;
        
        /// <summary>
        /// The list of messages to be sent to the model.
        /// </summary>
        public List<Message> Messages { get; set; } = new();
        
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