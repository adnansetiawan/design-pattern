using System;
namespace DP.Momento
{
    public class EditorState
    {
        public EditorState(string content)
        {
            Content = content;
        }
        public string Content { get; }
    }
}
