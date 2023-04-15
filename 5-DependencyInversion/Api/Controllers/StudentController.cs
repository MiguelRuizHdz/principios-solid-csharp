using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;
/**
 ************************************ Demo - Escenario ***************************************************
 * Tenemos una API que devuelve una lista de estudiantes. Esta API utiliza un repositorio que devuelve   *
 * una colección de datos y utiliza una bitácora (logbook) para guardar los eventos o llamadas a la API. *
 * Debemos aplicar el principio de inversión de la dependencia en esta API.                              *
 *********************************************************************************************************
 */
[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    StudentRepository studentRepository = new StudentRepository();
    Logbook logbook = new Logbook();

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        studentRepository.Add(student);
        logbook.Add($"The Student {student.Fullname} have been added");
    }
}
