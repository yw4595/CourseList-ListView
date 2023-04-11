using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseLib;
using PeopleAppGlobals;



namespace CourseList
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string Description { get; set; }
        public string Review { get; set; }

        public Course(string courseCode, string description, string review)
        {
            CourseCode = courseCode;
            Description = description;
            Review = review;
        }
    }

    public class Globals
    {
        public static SortedList courses = new SortedList();
    }

    public class MainForm : Form
    {
        private ListView courseListView;
        private TextBox courseCodeTextBox;
        private TextBox courseDescriptionTextBox;
        private RichTextBox reviewRichTextBox;
        private Button updateButton;

        public MainForm()
        {
            // Create and set up courseListView
            courseListView = new ListView();
            courseListView.Location = new Point(10, 10);
            courseListView.Size = new Size(200, 300);
            courseListView.View = View.Details;
            courseListView.Columns.Add("Course Code", -2, HorizontalAlignment.Left);
            courseListView.Columns.Add("Description", -2, HorizontalAlignment.Left);
            courseListView.Columns.Add("Review", -2, HorizontalAlignment.Left);
            courseListView.FullRowSelect = true;
            courseListView.GridLines = true;
            courseListView.MultiSelect = false;
            courseListView.Enabled = false;
            courseListView.SelectedIndexChanged += new EventHandler(courseListView_SelectedIndexChanged);

            // Add courseListView to the form's controls
            this.Controls.Add(courseListView);

            // Create and set up courseCodeTextBox
            courseCodeTextBox = new TextBox();
            courseCodeTextBox.Location = new Point(220, 10);
            courseCodeTextBox.Size = new Size(200, 20);
            courseCodeTextBox.Enabled = false;

            // Add courseCodeTextBox to the form's controls
            this.Controls.Add(courseCodeTextBox);

            // Create and set up courseDescriptionTextBox
            courseDescriptionTextBox = new TextBox();
            courseDescriptionTextBox.Location = new Point(220, 40);
            courseDescriptionTextBox.Size = new Size(200, 20);
            courseDescriptionTextBox.Enabled = false;

            // Add courseDescriptionTextBox to the form's controls
            this.Controls.Add(courseDescriptionTextBox);

            // Create and set up reviewRichTextBox
            reviewRichTextBox = new RichTextBox();
            reviewRichTextBox.Location = new Point(220, 70);
            reviewRichTextBox.Size = new Size(200, 100);
            reviewRichTextBox.Enabled = false;

            // Add reviewRichTextBox to the form's controls
            this.Controls.Add(reviewRichTextBox);

            // Create and set up updateButton
            updateButton = new Button();
            updateButton.Location = new Point(220, 180);
            updateButton.Size = new Size(100, 30);
            updateButton.Text = "Update";
            updateButton.Enabled = false;
            updateButton.Click += new EventHandler(updateButton_Click);

            // Add updateButton to the form's controls
            this.Controls.Add(updateButton);

            // Add some sample courses to Globals.courses SortedList
            Globals.courses.Add("CS101", new Course("CS101", "Intro to Computer Science", "Great course!"));
            Globals.courses.Add("MATH202", new Course("MATH202", "Linear Algebra", "Difficult but rewarding."));
            Globals.courses.Add("PHYS101", new Course("PHYS101", "Intro to Physics", "Fun and interesting."));

            // Call PaintListView with the first course code in Globals.courses
            PaintListView((string)Globals.courses.GetKey(0));
        }

        private void PaintListView(string selectedCoursecourseListView.Items.Clear();
   // Add each course as a new item to the list view
foreach (Course course in Globals.courses.Values)
{
    ListViewItem lvi = new ListViewItem(course.courseCode);
        lvi.SubItems.Add(course.description);
    lvi.SubItems.Add(course.review);
    courseListView.Items.Add(lvi);
}

// Select the row corresponding to the selected course
foreach (ListViewItem lvi in courseListView.Items)
{
    if (lvi.Text == selectedCourse)
    {
        lvi.Selected = true;
        courseListView.TopItem = lvi;
        break;
    }
}
}

    private void ExitButton__Click(object sender, EventArgs e)
{
    Application.Exit();
}
    }
}
    