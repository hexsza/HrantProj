using Microsoft.AspNetCore.JsonPatch.Operations;
using MySetProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyWPFApp
{

    public partial class MainWindow : Window
    {
        Set<Student> _men = new Set<Student>();
        Set<Student> _women = new Set<Student>();

        Set<Student> _reading = new Set<Student>();
        Set<Student> _writing = new Set<Student>();
        Set<Student> _arithmetic = new Set<Student>();

        Dictionary<string, Set<Student>> allSets = new Dictionary<string, Set<Student>>();

        public MainWindow()
        {

            Student Yura = new Student(1, "Yura", Gender.Male);
            Student Eghiazar = new Student(2, "Eghiazar", Gender.Male);
            Student Martin = new Student(3, "Martin", Gender.Male);
            _men.AddRange(new Student[] { Yura, Eghiazar, Martin });

            Student Milena = new Student(4, "Milena", Gender.Female);
            Student Lilit = new Student(5, "Lilit", Gender.Female);
            Student Lusine = new Student(6, "Lusine", Gender.Female);
            Student Maria = new Student(7, "Maria", Gender.Female);
            _women.AddRange(new Student[] { Milena, Lilit, Lusine, Maria });

            _reading.AddRange(new Student[] { Lilit, Lusine, Eghiazar });
            _writing.AddRange(new Student[] { Lilit, Milena, Yura });
            _arithmetic.AddRange(new Student[] { Maria, Martin, Eghiazar });

            allSets.Add("Men", _men);
            allSets.Add("Women", _women);
            allSets.Add("Reading", _reading);
            allSets.Add("Writing", _writing);
            allSets.Add("Arithmetic", _arithmetic);


            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string name in allSets.Keys)
            {
                leftSet.Items.Add(name);
                rightSet.Items.Add(name);
            }

            operation.Items.Add("UNION");
            operation.Items.Add("INTERSECTION");
            operation.Items.Add("DIFFERENCE");
            operation.Items.Add("SYMETRIC DIFF");

        }
        private void leftSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}