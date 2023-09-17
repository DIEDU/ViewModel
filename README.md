DISPLAYING MULTIPLE MODEL DATA IN A SINGLE VIEW IN ASP.NET MVC (URDU / HINDI9)
 
1. Using Extra class (viewmodel)
ViewModel.cs
public List<student> Students {get; set;}
public List<teacher> Teachers {get; set;}

Student.cs
id,
Name,
Gender,
@Class,
Fees
Teacher.cs
id,
Name,
Gender,
Qualification,
Salary
=================================================================================
 public class HomeController : Controller
     {  
       private ApplicationDbContext db;
        public HomeController()
        {
            db = new ApplicationDbContext();
        }
        public HomeController(ApplicationDbContext dbs)
        {
            db = dbs;
        }
        public ActionResult Index()
        {
          var std = getStudents();
          var techr = getTeachers();
          ViewModel  data = new ViewModel();
                           data.Students = std;
          data.Teachers = techr;
          return View(data);
        }
        public List<student> getStudents()
        {
            
            return db.students.ToList();
        }
        public List<teacher> getTeachers()
        {
            
            return db.teachers.ToList();
        }
========================================================================

@model List<RicaseV1.Models.HotelVM>

@{
    ViewBag.Title = "StudentList";
}

<h2>Student List</h2>

<table class="table">
    <thead>
        <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Class</th>
            <th>Fee</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in Model.Students)
        {
            <tr>
                <td>@item.Name</td>
                <td>@item.Gender</td>
                <td>@(item.@Class)</td>
                <td>@item.Fee</td>
            </tr>
        }
    </tbody>
</table>
<h2>Teacher List</h2>

<table class="table">
    <thead>
        <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Qualification</th>
            <th>Salary</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in Model.Teachers)
        {
            <tr>
                <td>@item.Name</td>
                <td>@item.Gender</td>
                <td>@item.Qualification</td>
                <td>@item.Salary</td>
            </tr>
        }
    </tbody>
</table>
====================================================================
1. Using ViewBag

public class HomeController : Controller
     {  
       private ApplicationDbContext db;
        public HomeController()
        {
            db = new ApplicationDbContext();
        }
        public HomeController(ApplicationDbContext dbs)
        {
            db = dbs;
        }
        public ActionResult Index()
        {
          var std = getStudents();
          var techr = getTeachers();
          
                           ViewBag.Students = std;
          ViewBag.Teachers = techr;
          return View();
        }
        public List<student> getStudents()
        {
            return db.students.ToList();
        }
        public List<teacher> getTeachers()
        {
            return db.teachers.ToList();
        }
========================================================================

@model List<RicaseV1.Models.HotelVM>

@{
    ViewBag.Title = "StudentList";
}

<h2>Student List</h2>

<table class="table">
    <thead>
        <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Class</th>
            <th>Fee</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in ViewBag.Students)
        {
            <tr>
                <td>@item.Name</td>
                <td>@item.Gender</td>
                <td>@(item.@Class)</td>
                <td>@item.Fee</td>
            </tr>
        }
    </tbody>
</table>
<h2>Teacher List</h2>

<table class="table">
    <thead>
        <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Qualification</th>
            <th>Salary</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in ViewBag.Teachers )
        {
            <tr>
                <td>@item.Name</td>
                <td>@item.Gender</td>
                <td>@item.Qualification</td>
                <td>@item.Salary</td>
            </tr>
        }
    </tbody>
</table>
====================================================================
3. Using ViewData

public class HomeController : Controller
     {  
       private ApplicationDbContext db;
        public HomeController()
        {
            db = new ApplicationDbContext();
        }
        public HomeController(ApplicationDbContext dbs)
        {
            db = dbs;
        }
        public ActionResult Index()
        {
          var std = getStudents();
          var techr = getTeachers();
          
                           ViewData.Students = std;
          ViewData.Teachers = techr;
          return View(data);
        }
        public List<student> getStudents()
        {
            return db.students.ToList();
        }
        public List<teacher> getTeachers()
        {
            return db.teachers.ToList();
        }
========================================================================

@model List<RicaseV1.Models.HotelVM>

@{
    ViewBag.Title = "StudentList";
}

<h2>Student List</h2>

<table class="table">
    <thead>
        <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Class</th>
            <th>Fee</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in (List<Students>)ViewData["Students"]
        {
            <tr>
                <td>@item.Name</td>
                <td>@item.Gender</td>
                <td>@(item.@Class)</td>
                <td>@item.Fee</td>
            </tr>
        }
    </tbody>
</table>
<h2>Teacher List</h2>

<table class="table">
    <thead>
        <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Qualification</th>
            <th>Salary</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in (List<Teachers>)ViewData["Teachers"]
        {
            <tr>
                <td>@item.Name</td>
                <td>@item.Gender</td>
                <td>@item.Qualification</td>
                <td>@item.Salary</td>
            </tr>
        }
    </tbody>
</table>
====================================================================
3. Using ViewData

public class HomeController : Controller
     {  
       private ApplicationDbContext db;
        public HomeController()
        {
            db = new ApplicationDbContext();
        }
        public HomeController(ApplicationDbContext dbs)
        {
            db = dbs;
        }
        public ActionResult Index()
        {
          var std = getStudents();
          var techr = getTeachers();
          
                           TempData["Students"] = std;
          TempData["Teachers"] = techr;
          return View(data);
        }
        public List<student> getStudents()
        {
            return db.students.ToList();
        }
        public List<teacher> getTeachers()
        {
            return db.teachers.ToList();
        }
========================================================================

@model List<RicaseV1.Models.HotelVM>

@{
    ViewBag.Title = "StudentList";
}

<h2>Student List</h2>

<table class="table">
    <thead>
        <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Class</th>
            <th>Fee</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in (List<Students>)TempData["Students"]
        {
            <tr>
                <td>@item.Name</td>
                <td>@item.Gender</td>
                <td>@(item.@Class)</td>
                <td>@item.Fee</td>
            </tr>
        }
    </tbody>
</table>
<h2>Teacher List</h2>

<table class="table">
    <thead>
        <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Qualification</th>
            <th>Salary</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in (List<Teachers>)TempData["Teachers"]
        {
            <tr>
                <td>@item.Name</td>
                <td>@item.Gender</td>
                <td>@item.Qualification</td>
                <td>@item.Salary</td>
            </tr>
        }
    </tbody>
</table>
====================================================================
3. Using Session

public class HomeController : Controller
     {  
       private ApplicationDbContext db;
        public HomeController()
        {
            db = new ApplicationDbContext();
        }
        public HomeController(ApplicationDbContext dbs)
        {
            db = dbs;
        }
        public ActionResult Index()
        {
          var std = getStudents();
          var techr = getTeachers();
          
                           Session["Students"] = std;
          Session["Teachers"] = techr;
          return View(data);
        }
        public List<student> getStudents()
        {
            return db.students.ToList();
        }
        public List<teacher> getTeachers()
        {
            return db.teachers.ToList();
        }
========================================================================

@model List<RicaseV1.Models.HotelVM>

@{
    ViewBag.Title = "StudentList";
}

<h2>Student List</h2>

<table class="table">
    <thead>
        <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Class</th>
            <th>Fee</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in (List<Students>)Session["Students"]
        {
            <tr>
                <td>@item.Name</td>
                <td>@item.Gender</td>
                <td>@(item.@Class)</td>
                <td>@item.Fee</td>
            </tr>
        }
    </tbody>
</table>
<h2>Teacher List</h2>

<table class="table">
    <thead>
        <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Qualification</th>
            <th>Salary</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in (List<Teachers>)Session["Teachers"]
        {
            <tr>
                <td>@item.Name</td>
                <td>@item.Gender</td>
                <td>@item.Qualification</td>
                <td>@item.Salary</td>
            </tr>
        }
    </tbody>
</table>
====================================================================
3. Using PartialView

public class HomeController : Controller
     {  
       private ApplicationDbContext db;
        public HomeController()
        {
            db = new ApplicationDbContext();
        }
        public HomeController(ApplicationDbContext dbs)
        {
            db = dbs;
        }
        public ActionResult Index()
        {
          return View(data);
        }
public PartialViewResult Students()
        {
          var std = getStudents();
           return PartialView("_students", std); 
        }
public PartialViewResult Teachers()
        {
          var techr = getTeachers();
           return PartialView("_teachers", techr); 
        }
        public List<student> getStudents()
        {
            return db.students.ToList();
        }
        public List<teacher> getTeachers()
        {
            return db.teachers.ToList();
        }
====================================================================
Shared folder me do PartialView (_students.cshtml & _teachers.cshtml) view banaye. PartialView banate samay PartialView k option check kar k next kre)
 

_students.cshtml 

@model IEnumerable<RicaseV1.Models.students>

@{
    ViewBag.Title = "StudentList";
}

<h2>Student List</h2>

<table class="table">
    <thead>
        <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Class</th>
            <th>Fee</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in Model)
        {
            <tr>
                <td>@item.Name</td>
                <td>@item.Gender</td>
                <td>@(item.@Class)</td>
                <td>@item.Fee</td>
            </tr>
        }
    </tbody>
</table>
==============================================================
_teacher.cshtml
@model IEnumerable<RicaseV1.Models.teachers>

<h2>Teacher List</h2>

<table class="table">
    <thead>
        <tr>
            <th>Name</th>
            <th>Gender</th>
            <th>Qualification</th>
            <th>Salary</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var item in Model)
        {
            <tr>
                <td>@item.Name</td>
                <td>@item.Gender</td>
                <td>@item.Qualification</td>
                <td>@item.Salary</td>
            </tr>
        }
    </tbody>
</table>
=======================================================================
index.cshtml
@model  RicaseV1.Models.HotelVM

@{
    ViewBag.Title = "Index";
}

@{
    Html.RenderAction("Students");
}

@{
    Html.RenderAction("Teachers");
}








