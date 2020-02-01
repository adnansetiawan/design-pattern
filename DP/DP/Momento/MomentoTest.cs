using System;
namespace DP.Momento
{
    public static class MomentoTest
    {
        public static void Test()
        {
            History history = new History();
            Editor editor = new Editor();
            editor.Content = "A";
            history.Push(editor.CreateState());
            editor.Content = "B";
            history.Push(editor.CreateState());
            editor.Content = "C";
            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);
        }
    }
}
