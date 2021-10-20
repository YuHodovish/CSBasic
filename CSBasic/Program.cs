namespace CSBasic
{
    class MagicialGirl
    {
        private string nameField;
        public string Name
        {
            get
            {
                System.Console.WriteLine("Name プロパティを取得");
                return nameField;
            }
            set
            {
                System.Console.WriteLine("Name　プロパティを「" + value + "」に設定");
                nameField = value;
            }
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            MagicialGirl AC = new MagicialGirl();
            AC.Name = "ArmoredCore";
            System.Console.WriteLine("Name=" + AC.Name);
        }
    }
}
