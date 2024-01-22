using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachLienKetDon
{

    class Node
    {
        private float info;
        private Node next;
        public Node(float x)
        {
            info = x;
            next = null;
        }
        public float Info
        {
            set { this.info = value; }
            get { return info; }
        }
        public Node Next
        {
            set { this.next = value; }
            get { return next; }
        }
    }
    class SingleLinkList
    {
        private Node Head;
        public SingleLinkList()
        {
            Head = null;
        }
        public void AddHead(float x)
        {
            Node p = new Node(x);
            p.Next = Head;
            Head = p;
        }
        public void AddLast(float x)
        {
            Node p = new Node(x);
            if (Head == null)
            {
                Head = p;
            }
            else
            {
                Node q = Head;
                while (q.Next != null)
                { q = q.Next; }
            }
            p.Next = p;
        }
        public Node findMax()
        {
            Node max = Head;
            Node p = Head.Next;
            while (p != null)
            {
                if (p.Info > max.Info)
                {
                    max = p;
                }
                p = p.Next;
            }
            return max;
        }
        public float Avg()
        {
            float sum = 0;
            int count = 0;
            Node p = Head;
            while (p != null)
            {
                sum += p.Info;
                count++;
                p = p.Next;
            }
            return sum / count;
        }

        public void xuat()
        {
            Node p = Head;
            while (p != null)
            {
                Console.Write($"{ p.Info}  ");
                p = p.Next;
            }

        }
        public void DeleteHead()
        {
            if (Head != null)
            {
                Node p = Head;
                Head = Head.Next;
                p.Next = null;
            }
        }

        public void DeleteLast()
        {
            if (Head != null)
            {
                Node p = Head;
                Node q = null;
                while (p.Next != null)
                {
                    q = p;
                    p = p.Next;
                }
            }
        }
        public void DeleteNode(float x)
        {
            if (Head != null)
            {
                Node p = Head;
                Node q = null;
                while (p != null && p.Info != x)
                {
                    q = p;
                    p = p.Next;
                }
                if (p != null)
                {
                    if (p == Head)
                        DeleteHead();
                    else
                    {
                        q.Next = p.Next;
                        p.Next = null;
                    }
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkList l = new SingleLinkList();
            Console.WriteLine( " Nhpa Danh Sach");
            NhapDanhSach(l);

            l.xuat();
            
            Console.WriteLine("\n Nhap danh sach duoc tao : ");
      
            l.DeleteHead();
            l.xuat();


            Console.WriteLine("\n Danh sach lien ket sau khi xoa nut dau: ");
            l.DeleteHead();
                     
            Console.WriteLine("\n Danh sach lien ket xoa nut cuoi: ");
            l.DeleteLast();
   
            Console.WriteLine("\n Nhap gia x can xoa:");
            float x = float.Parse(Console.ReadLine());
            l.DeleteNode(x);

            Console.WriteLine("\n Danh sach lien ket sau khi xoa nut co gia tri x: ");
            l.xuat();

            Node max = l.findMax();
            Console.WriteLine("\n Nut co gia tri lon nhat: { max.Info}");

            Console.ReadLine();
        }

        static void NhapDanhSach(SingleLinkList l)
        {
            string chon = "y";
            float x;
            while (chon !="n")
            {
                Console.Write(" Nhap gia tri nut: ");
                x = float.Parse(Console.ReadLine());               
                Console.Write(" Tiep tuc ? (Y/N): ");
                chon = Console.ReadLine();
                if (chon == "n")
                    break;
            }    
        }
    } 
}
