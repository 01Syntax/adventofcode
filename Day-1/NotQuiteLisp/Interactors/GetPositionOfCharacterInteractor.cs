using NotQuiteLisp.Interfaces;

namespace NotQuiteLisp.Interactors
{
    public class GetPositionOfCharacterInteractor(IFileManager fileManager) : IGetPositionOfCharacterInteractor
    {
        public int Handle(string filePath)
        {
            var data = fileManager.ReadFile(filePath);
            var position = 0;

            for (int i = 0; i < data.Length; i++)
            {
                var c = data[i];
                if (c == '(')
                {
                    position++;
                }

                if (c == ')')
                {
                    position--;
                }
                if (position < 0)
                {
                    return i + 1;
                }
            }
            return position;
        }
    }
}
