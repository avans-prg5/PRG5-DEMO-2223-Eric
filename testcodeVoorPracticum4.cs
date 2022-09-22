 class MainClass
    {
        public static void ShowFirstToLast(NawDoublyLinkedList src)
        {
            // 2x weergeven eerst first -> last via next
            // daarna last -> first via previous.
            // uitkomst moet exact gespiegeld zijn.
            var firstToLast = src.First;
            while (firstToLast != null)
            {
                Console.Write($"{firstToLast.Naw.Woonplaats},");
                firstToLast = firstToLast.Next;
            }

        }

        public static void ShowLastToFirst(NawDoublyLinkedList src)
        {
            Console.WriteLine();
            var lastToFirst = src.Last;
            while (lastToFirst != null)
            {
                Console.Write($"{lastToFirst.Naw.Woonplaats},");
                lastToFirst = lastToFirst.Previous;
            }
        }


        public static void Main(string[] args)
        {
            var testLijst = new NawDoublyLinkedList();
            var naw1 = new NAW("d", "d", "d");
            var naw2 = new NAW("b", "b", "b");
            testLijst.InsertHead(naw1);
            testLijst.InsertHead(naw2);
            testLijst.InsertHead(new NAW("c", "c", "c"));
            testLijst.InsertHead(new NAW("a", "a", "a"));

            ShowLastToFirst(testLijst);
            ShowFirstToLast(testLijst);

            //Test voor ItemAtIndex
            // verwacht op basis van testdata : A,D, indexoutofrange;
            try
            {
                Console.Write(testLijst.ItemAtIndex(0));
                Console.Write(testLijst.ItemAtIndex(3));
                Console.WriteLine(testLijst.ItemAtIndex(4));
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            Console.ReadKey();
        }
    }
