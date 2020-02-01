using System;
using System.Collections.Generic;
using System.Linq;
namespace DP.Momento
{
    public class History
    {
        private List<EditorState> states = new List<EditorState>();
        public void Push(EditorState editorState)
        {
            states.Add(editorState);
        }
        public EditorState Pop()
        {
            var lastItem = states.LastOrDefault();
            if (lastItem != null)
                states.Remove(lastItem);
            return lastItem;

        }
    }
}
