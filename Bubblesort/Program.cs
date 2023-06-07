using System.ComponentModel;
//BFT21
// Rahim NIkfar
public class sorting
{



    public static int[] GandalfBubblesort(int[] Gandalf )
    {


        int temp = 0;

        for (int write = 0; write < Gandalf.Length; write++)
        {
            for (int sort = 0; sort < Gandalf.Length - 1; sort++)
            {
                if (Gandalf[sort] > Gandalf[sort + 1])
                {
                    temp = Gandalf[sort + 1];
                    Gandalf[sort + 1] = Gandalf[sort];
                    Gandalf[sort] = temp;
                }
            }
            Console.Write("{0} ", Gandalf[write]);
        }
        return Gandalf;
    }
}