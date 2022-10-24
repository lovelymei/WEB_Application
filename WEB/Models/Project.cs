namespace WEB.Models
{
    /// <summary>
    /// Проект
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Идентикатор проекта
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название проекта
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Компания-заказчик
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// Компания-исполнитель
        /// </summary>
        public string Executor { get; set; }

        /// <summary>
        /// Приоритет
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Сотрудники в проекте
        /// </summary>
        public List<Employee>? Employees { get; set; }

        /// <summary>
        /// Руководитель проекта 
        /// </summary>
        public Employee? Supervisor { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime? EndDate { get; set; }
    }
}
