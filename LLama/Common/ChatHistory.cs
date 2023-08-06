﻿using System.Collections.Generic;

namespace LLama.Common
{
    /// <summary>
    /// Role of the message author, e.g. user/assistant/system
    /// </summary>
    public enum AuthorRole
    {
        /// <summary>
        /// Role is unknown
        /// </summary>
        Unknown = -1,

        /// <summary>
        /// Message comes from a "system" prompt, not written by a user or language model
        /// </summary>
        System = 0,

        /// <summary>
        /// Message comes from the user
        /// </summary>
        User = 1,

        /// <summary>
        /// Messages was generated by the language model
        /// </summary>
        Assistant = 2,
    }

    // copy from semantic-kernel
    /// <summary>
    /// The chat history class
    /// </summary>
    public class ChatHistory
    {

        /// <summary>
        /// Chat message representation
        /// </summary>
        public class Message
        {
            /// <summary>
            /// Role of the message author, e.g. user/assistant/system
            /// </summary>
            public AuthorRole AuthorRole { get; set; }

            /// <summary>
            /// Message content
            /// </summary>
            public string Content { get; set; }

            /// <summary>
            /// Create a new instance
            /// </summary>
            /// <param name="authorRole">Role of message author</param>
            /// <param name="content">Message content</param>
            public Message(AuthorRole authorRole, string content)
            {
                this.AuthorRole = authorRole;
                this.Content = content;
            }
        }

        /// <summary>
        /// List of messages in the chat
        /// </summary>
        public List<Message> Messages { get; }

        /// <summary>
        /// Create a new instance of the chat content class
        /// </summary>
        public ChatHistory()
        {
            this.Messages = new List<Message>();
        }

        /// <summary>
        /// Add a message to the chat history
        /// </summary>
        /// <param name="authorRole">Role of the message author</param>
        /// <param name="content">Message content</param>
        public void AddMessage(AuthorRole authorRole, string content)
        {
            this.Messages.Add(new Message(authorRole, content));
        }
    }

}