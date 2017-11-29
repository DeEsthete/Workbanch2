using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Recept[] recept = new Recept[7];

            Material[] material = new Material[7];
            material[0] = new Material("NULL", -1);
            material[1] = new Material("Дерево", 0);
            material[2] = new Material("Железо", 1);
            material[3] = new Material("Алмаз", 2);
            material[4] = new Material("Золото", 3);
            material[5] = new Material("Мифрил", 4);
            material[6] = new Material("Камень", 5);

            Material[] WoodAxe = new Material[9];
            WoodAxe[0] = new Material(material[1]);
            WoodAxe[1] = new Material(material[1]);
            WoodAxe[2] = new Material(material[0]);
            WoodAxe[3] = new Material(material[1]);
            WoodAxe[4] = new Material(material[1]);
            WoodAxe[5] = new Material(material[0]);
            WoodAxe[6] = new Material(material[0]);
            WoodAxe[7] = new Material(material[1]);
            WoodAxe[8] = new Material(material[0]);
            recept[0] = new Recept("WoodAxe", WoodAxe);

            Material[] WoodSword = new Material[9];
            WoodSword[0] = new Material(material[0]);
            WoodSword[1] = new Material(material[1]);
            WoodSword[2] = new Material(material[0]);
            WoodSword[3] = new Material(material[0]);
            WoodSword[4] = new Material(material[1]);
            WoodSword[5] = new Material(material[0]);
            WoodSword[6] = new Material(material[0]);
            WoodSword[7] = new Material(material[1]);
            WoodSword[8] = new Material(material[0]);
            recept[1] = new Recept("WoodSword", WoodSword);

            Material[] StoneAxe = new Material[9];
            StoneAxe[0] = new Material(material[1]);
            StoneAxe[1] = new Material(material[1]);
            StoneAxe[2] = new Material(material[0]);
            StoneAxe[3] = new Material(material[1]);
            StoneAxe[4] = new Material(material[1]);
            StoneAxe[5] = new Material(material[0]);
            StoneAxe[6] = new Material(material[0]);
            StoneAxe[7] = new Material(material[1]);
            StoneAxe[8] = new Material(material[0]);
            recept[2] = new Recept("StoneAxe", StoneAxe);

            Material[] StoneSword = new Material[9];
            StoneSword[0] = new Material(material[0]);
            StoneSword[1] = new Material(material[1]);
            StoneSword[2] = new Material(material[0]);
            StoneSword[3] = new Material(material[0]);
            StoneSword[4] = new Material(material[1]);
            StoneSword[5] = new Material(material[0]);
            StoneSword[6] = new Material(material[0]);
            StoneSword[7] = new Material(material[1]);
            StoneSword[8] = new Material(material[0]);
            recept[3] = new Recept("StoneSword", StoneSword);

            Material[] WoodShovel = new Material[9];
            WoodShovel[0] = new Material(material[0]);
            WoodShovel[1] = new Material(material[1]);
            WoodShovel[2] = new Material(material[0]);
            WoodShovel[3] = new Material(material[0]);
            WoodShovel[4] = new Material(material[1]);
            WoodShovel[5] = new Material(material[0]);
            WoodShovel[6] = new Material(material[0]);
            WoodShovel[7] = new Material(material[1]);
            WoodShovel[8] = new Material(material[0]);
            recept[4] = new Recept("WoodShovel", WoodShovel);

            Material[] StoneShovel = new Material[9];
            StoneShovel[0] = new Material(material[1]);
            StoneShovel[1] = new Material(material[1]);
            StoneShovel[2] = new Material(material[1]);
            StoneShovel[3] = new Material(material[0]);
            StoneShovel[4] = new Material(material[1]);
            StoneShovel[5] = new Material(material[0]);
            StoneShovel[6] = new Material(material[0]);
            StoneShovel[7] = new Material(material[1]);
            StoneShovel[8] = new Material(material[0]);
            recept[5] = new Recept("StoneShovel", StoneShovel);

            Workbench workbench = new Workbench(recept, material);
            workbench.Menu();
            Console.ReadLine();
        }
    }
}
