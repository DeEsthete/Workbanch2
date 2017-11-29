using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1,2      1,4     1,6
// 3,2      3,4     3,6
// 5,2      5,4     5,6
namespace Operator
{
    public class Workbench
    {
        private Recept[] _recept;
        private Material[] _material;
        private Material[] _tableDraft = new Material[9];
        private string[] _tableDrawing = new string[7];

        public Workbench(Recept[] recept, Material[] material)
        {
            _recept = recept;
            _material = material;
            _tableDrawing[0] = "-------";
            _tableDrawing[1] = "| | | |";
            _tableDrawing[2] = "-------";
            _tableDrawing[3] = "| | | |";
            _tableDrawing[4] = "-------";
            _tableDrawing[5] = "| | | |";
            _tableDrawing[6] = "-------";
            for (int i = 0; i < _tableDraft.Length; i++)
            {
                _tableDraft[i] = new Material(_material[0]);
            }
        }

        public void Menu()
        {
            bool switchForWhile = true;
            int h;
            while (switchForWhile)
            {
                for (int i = 0; i < _tableDrawing.Length; i++)
                {
                    Console.WriteLine(_tableDrawing[i]);
                }
                for (int i = 0; i < _material.Length; i++)
                {
                    Console.WriteLine(i + " - " + _material[i].GetName());
                }
                Console.WriteLine();
                Console.WriteLine("1 - Добавить материал");
                Console.WriteLine("2 - Проверить рецепт");
                Console.WriteLine("3 - Очистить верстак");
                Console.WriteLine("0 - Покинуть меню верстака");
                h = int.Parse(Console.ReadLine());
                if (h == 1)
                {
                    int g = 0;
                    Console.WriteLine("Выберите номер необходимого ресурса исходя из таблицы");
                    g = int.Parse(Console.ReadLine());
                    int y, x;
                    Console.WriteLine("Введите координаты y, x (нумерация начинается с '1')");
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                    int l = (x * y);
                    AddMaterial(x, y, _material[g]);
                }
                else if (h == 2)
                {
                    if (CheckingRecipe() == -1)
                    {
                        Console.WriteLine("Рецепт выложен неправильно, попробуйте еще раз");
                    }
                    else
                    {
                        Console.WriteLine("У вас получится - " + _recept[CheckingRecipe()].GetName());
                    }
                }
                else if (h == 3)
                {
                    _tableDrawing[0] = "-------";
                    _tableDrawing[1] = "| | | |";
                    _tableDrawing[2] = "-------";
                    _tableDrawing[3] = "| | | |";
                    _tableDrawing[4] = "-------";
                    _tableDrawing[5] = "| | | |";
                    _tableDrawing[6] = "-------";
                }
                else if (h == 0)
                {
                    switchForWhile = false;
                }
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void AddReceptSwitch(Recept temp)
        {
            Array.Resize(ref _recept, (_recept.Length + 1));
            _recept[_recept.Length - 1].SetName(temp.GetName());
            _recept[_recept.Length - 1].SetResourceLocation(temp.GetResourceLocation());
        }

        public void AddMaterialSwitch(Material temp)
        {
            Array.Resize(ref _material, (_material.Length + 1));
            _material[_material.Length - 1].SetName(temp.GetName());
            _material[_material.Length - 1].SetId(temp.GetId());
        }

        public void AddMaterial(int AcceptedX, int AcceptedY, Material material)
        {
            StringBuilder str = new StringBuilder("| | | |");
            int x = AcceptedX, y = AcceptedY;
            if (AcceptedX == 1 && AcceptedY == 1)
            {
                x = 1;
                y = 1;
                _tableDraft[0] = material;
            }
            else if (AcceptedX == 1 && AcceptedY == 2)
            {
                x = 3;
                y = 1;
                _tableDraft[3] = material;
            }
            else if (AcceptedX == 2 && AcceptedY == 1)
            {
                x = 1;
                y = 3;
                _tableDraft[1] = material;
            }
            else if (AcceptedX == 1 && AcceptedY == 3)
            {
                x = 5;
                y = 1;
                _tableDraft[6] = material;
            }
            else if (AcceptedX == 2 && AcceptedY == 2)
            {
                x = 3;
                y = 3;
                _tableDraft[4] = material;
            }
            else if (AcceptedX == 2 && AcceptedY == 3)
            {
                x = 5;
                y = 3;
                _tableDraft[7] = material;
            }
            else if (AcceptedX == 3 && AcceptedY == 1)
            {
                x = 1;
                y = 5;
                _tableDraft[2] = material;
            }
            else if (AcceptedX == 3 && AcceptedY == 2)
            {
                x = 3;
                y = 5;
                _tableDraft[5] = material;
            }
            else if (AcceptedX == 3 && AcceptedY == 3)
            {
                x = 5;
                y = 5;
                _tableDraft[8] = material;
            }
            if (material.GetId() != -1)
            {
                ReplaceCharInString(ref _tableDrawing[x], y, '0');
            }
            else
            {
                ReplaceCharInString(ref _tableDrawing[x], y, ' ');
            }
        }

        public int CheckingRecipe()
        {
            for (int i = 0; i < _recept.Length-1; i++)
            {
                if (_recept[i] == _tableDraft)
                {
                    return i;
                }
            }
            return -1;
        }

        /* Замена в строке str символа по индексу index на newSymb
        */
        public void ReplaceCharInString(ref String str, int index, Char newSymb)
        {
            str = str.Remove(index, 1).Insert(index, newSymb.ToString());
        }
    }
}
