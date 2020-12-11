using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Services.Client;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSPYBModel;

namespace WCFClient
{
    public partial class Form1 : Form
    {

        WSPYBEntities context;
        Uri uri = new Uri("https://localhost:44373/WcfDataService1.svc");
        public Form1()
        {
            InitializeComponent();
            context = new WSPYBEntities(uri);

            DataServiceQuery<Student> query = context.Student.AddQueryOption("$orderby", "id");

            DataServiceCollection<Student> students = new DataServiceCollection<Student>(query, TrackingMode.None);

            foreach(var stud in students)
            {
                comboBox1.Items.Add(stud.id);
                comboBox2.Items.Add(stud.id);
                comboBox3.Items.Add(stud.id);
            }

        }

        private void GetAllStudents_Click(object sender, EventArgs e)
        {
            GetStudents();
        }

        private void GetStudents()
        {
            var query = from o in context.Student
                        select o;

            DataServiceCollection<Student> students = new DataServiceCollection<Student>(query, TrackingMode.None);
            dataGridView1.DataSource = students;
        }

        private void GetAllNotes_Click(object sender, EventArgs e)
        {
            GetNotes();
        }

        private void GetNotes()
        {
            var query = from o in context.Note
                        select o;

            DataServiceCollection<Note> notes = new DataServiceCollection<Note>(query, TrackingMode.None);
            dataGridView1.DataSource = notes;
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.name = textBox1.Text;
            context.AddToStudent(student);
            context.SaveChanges();
            GetStudents();
        }

        private void UpdateStudent_Click(object sender, EventArgs e)
        {
            var query = from o in context.Student.Expand("id")
                          where o.id == int.Parse(comboBox1.Text)
                          select o;

            DataServiceCollection<Student> students = new DataServiceCollection<Student>(query, TrackingMode.None);
            var student = students.First();
            student.name = textBox2.Text;
            context.UpdateObject(student);
            context.SaveChanges();
            GetStudents();
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            var query = from o in context.Student.Expand("id")
                        where o.id == int.Parse(comboBox2.Text)
                        select o;

            DataServiceCollection<Student> students = new DataServiceCollection<Student>(query, TrackingMode.None);
            var student = students.First();
            context.DeleteObject(student);
            context.SaveChanges();
            GetStudents();
        }

        private void OrderStudentsByName_Click(object sender, EventArgs e)
        {
            DataServiceQuery<Student> query = context.Student
            .AddQueryOption("$orderby", "name");

            DataServiceCollection<Student> students = new DataServiceCollection<Student>(query, TrackingMode.None);

            dataGridView1.DataSource = students;
        }

        private void Upd_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

            DataServiceQuery<Student> query = context.Student.AddQueryOption("$orderby", "id");

            DataServiceCollection<Student> students = new DataServiceCollection<Student>(query, TrackingMode.None);

           
            foreach (var stud in students)
            {
                comboBox1.Items.Add(stud.id);
                comboBox2.Items.Add(stud.id);
                comboBox3.Items.Add(stud.id);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label10.Text = trackBar1.Value.ToString();
        }

        private void AddNewNote_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            note.studentId = int.Parse(comboBox3.Text);
            note.subject = textBox3.Text;
            note.note1 = trackBar1.Value;

            context.AddToNote(note);
            context.SaveChanges();
            GetNotes();
        }

        private void FindByName_Click(object sender, EventArgs e)
        {
            DataServiceQuery<Student> query = context.Student.AddQueryOption("$filter", $"name eq '{textBox4.Text}'");
            DataServiceCollection<Student> students = new DataServiceCollection<Student>(query, TrackingMode.None);

            dataGridView1.DataSource = students;
        }

        private void OrderByNote_Click(object sender, EventArgs e)
        {
            DataServiceQuery<Note> query = context.Note
            .AddQueryOption("$orderby", "note1");

            DataServiceCollection<Note> notes = new DataServiceCollection<Note>(query, TrackingMode.None);

            dataGridView1.DataSource = notes;
        }
    }
}
