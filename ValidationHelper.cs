using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HRD
{
    public static class ValidationHelper
    {
        public static bool ValidateEmployee(
            string name, string lname, string pname, string pseries, string pnumber,
            string pwho, string reg, string res, string phone, string tg,
            string email, DateTime birthDate, DateTime pWhenDate,
            out string errorMessage)
        {
            errorMessage = string.Empty;
            if (string.IsNullOrWhiteSpace(lname) || !Regex.IsMatch(lname, @"^[а-яА-ЯёЁ]+$"))
            {
                errorMessage = "Заполните поле Фамилия!";
                return false;
            }

            if (!Regex.IsMatch(lname, @"^[а-яА-ЯёЁ]+$"))
            {
                errorMessage = "Фамилия должна содержать только буквы кириллицы!";
                return false;
            }
            // Проверка имени и фамилии (не пустые и только буквы)
            if (string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(name, @"^[а-яА-ЯёЁ]+$"))
            {
                errorMessage = "Заполните поле Имя!";
                return false;
            }

            if (!Regex.IsMatch(name, @"^[а-яА-ЯёЁ]+$"))
            {
                errorMessage = "Имя должно содержать только буквы кириллицы!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(lname) || !Regex.IsMatch(lname, @"^[а-яА-ЯёЁ]+$"))
            {
                errorMessage = "Заполните поле Фамилия!";
                return false;
            }

            if (!Regex.IsMatch(lname, @"^[а-яА-ЯёЁ]+$"))
            {
                errorMessage = "Фамилия должна содержать только буквы кириллицы!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(lname) || (!string.IsNullOrWhiteSpace(pname) && !Regex.IsMatch(pname, @"^[а-яА-ЯёЁ]+$")))
            {
                errorMessage = "Отчество должно содержать только буквы кириллицы!";
                return false;
            }

            // Проверка паспортных данных
            if (string.IsNullOrWhiteSpace(pseries) || !Regex.IsMatch(pseries, @"^\d{4}$"))
            {
                errorMessage = "Серия паспорта должна состоять из 4 цифр";
                return false;
            }

            if (string.IsNullOrWhiteSpace(pnumber) || !Regex.IsMatch(pnumber, @"^\d{6}$"))
            {
                errorMessage = "Номер паспорта должен состоять из 6 цифр";
                return false;
            }

            if (string.IsNullOrWhiteSpace(pwho))
            {
                errorMessage = "Укажите кем выдан паспорт";
                return false;
            }

            // Проверка адресов
            if (string.IsNullOrWhiteSpace(reg))
            {
                errorMessage = "Укажите адрес регистрации";
                return false;
            }

            if (string.IsNullOrWhiteSpace(res))
            {
                errorMessage = "Укажите адрес проживания";
                return false;
            }

            // Проверка телефона
            if (!ValidatePhone(phone))
            {
                errorMessage = "Телефон должен быть в формате +7XXXXXXXXXX";
                return false;
            }

            // Проверка телеграм
            if (!string.IsNullOrWhiteSpace(tg) && !ValidateTelegram(tg))
            {
                errorMessage = "Telegram должен начинаться с @";
                return false;
            }

            // Проверка email
            if (!string.IsNullOrWhiteSpace(email) && !ValidateEmail(email))
            {
                errorMessage = "Неверный формат email";
                return false;
            }

            // Проверка дат
            if (!ValidateDates(birthDate, pWhenDate))
            {
                errorMessage = "Дата выдачи паспорта должна быть позже даты рождения";
                return false;
            }

            return true;
        }

        public static bool ValidateProject(
            string name, string description, DateTime pds, DateTime pde,
            DateTime? fds, DateTime? fde, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(name))
            {
                errorMessage = "Название проекта не может быть пустым";
                return false;
            }

            if (pde <= pds)
            {
                errorMessage = "Дата окончания проекта должна быть позже даты начала";
                return false;
            }

            if (fds.HasValue && fde.HasValue && fde.Value <= fds.Value)
            {
                errorMessage = "Фактическая дата окончания должна быть позже даты начала";
                return false;
            }

            return true;
        }

        public static bool ValidatePost(string name, decimal pay, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(name))
            {
                errorMessage = "Название должности не может быть пустым";
                return false;
            }

            if (pay <= 0)
            {
                errorMessage = "Зарплата должна быть больше нуля";
                return false;
            }

            return true;
        }

        public static bool ValidateQualification(string name, decimal coef, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(name))
            {
                errorMessage = "Название квалификации не может быть пустым";
                return false;
            }

            // Проверка на положительное значение
            if (coef <= 0)
            {
                errorMessage = "Коэффициент должен быть больше нуля";
                return false;
            }

            // Проверка на максимальное значение (999.99)
            if (coef >= 1000)
            {
                errorMessage = "Коэффициент не может быть больше или равен 1000";
                return false;
            }

            // Проверка количества десятичных знаков
            string[] parts = coef.ToString().Split(',');
            if (parts.Length > 1 && parts[1].Length > 2)
            {
                errorMessage = "Коэффициент может содержать не более двух знаков после запятой";
                return false;
            }

            // Проверка общей длины числа
            string numberWithoutDecimal = coef.ToString().Replace(",", "").Replace(".", "");
            if (numberWithoutDecimal.Length > 5)
            {
                errorMessage = "Коэффициент не может содержать более 5 цифр в общей сложности";
                return false;
            }

            return true;
        }

        private static bool ValidatePhone(string phone)
        {
            return !string.IsNullOrWhiteSpace(phone) && 
                   Regex.IsMatch(phone, @"^\+7\d{10}$");
        }

        private static bool ValidateTelegram(string tg)
        {
            return tg.StartsWith("@");
        }

        private static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase);
        }

        private static bool ValidateDates(DateTime birthDate, DateTime pWhenDate)
        {
            return pWhenDate > birthDate;
        }

        public static bool ValidateEmployeeSkills(List<Skill> skills, SqlConnection connection, out string errorMessage)
        {
            errorMessage = string.Empty;

            foreach (var skill in skills)
            {
                string checkSql = $"SELECT COUNT(*) FROM Skill WHERE ID_Skill = '{skill.skillId}'";
                using (SqlCommand command = new SqlCommand(checkSql, connection))
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                        connection.Open();

                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        errorMessage = $"Навыка '{skill.skillName}' не существует в базе данных или он был удалён!";
                        return false;
                    }
                }

                // Проверка уровня навыка
                if (string.IsNullOrWhiteSpace(skill.skillLevel))
                {
                    errorMessage = $"Не указан уровень для навыка {skill.skillName}";
                    return false;
                }

                if (Convert.ToInt32(skill.skillLevel) < 0 || Convert.ToInt32(skill.skillLevel) > 10)
                {
                    errorMessage = $"Уровень навыка {skill.skillName} выходит из диапазона от 0 до 10!";
                    return false;
                }
            }

            return true;

            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
                    

        }

        public static bool ValidateEmployeePosition(string positionId, SqlConnection connection, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrEmpty(positionId))
            {
                errorMessage = "Необходимо выбрать должность сотрудника!";
                return false;
            }
            
            try
            {
                string checkSql = $"SELECT COUNT(*) FROM Post WHERE ID_Po = '{positionId}'";
                using (SqlCommand command = new SqlCommand(checkSql, connection))
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                        connection.Open();

                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        errorMessage = "Выбранная должность не существует в базе данных или была удалена!";
                        return false;
                    }
                }
                return true;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public static bool ValidateEmployeeQualification(string qualificationId, SqlConnection connection, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrEmpty(qualificationId))
            {
                errorMessage = "Необходимо выбрать квалификацию сотрудника!";
                return false;
            }
            
            try
            {
                string checkSql = $"SELECT COUNT(*) FROM Qualification WHERE ID_Qual = '{qualificationId}'";
                using (SqlCommand command = new SqlCommand(checkSql, connection))
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                        connection.Open();

                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        errorMessage = "Выбранная квалификация не существует в базе данных или была удалена!";
                        return false;
                    }
                }
                return true;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public static bool ValidateProjectTeam(List<Employee> team, SqlConnection connection, out string errorMessage)
        {
            errorMessage = string.Empty;

            try
            {
                foreach (var employee in team)
                {
                    string checkSql = $"SELECT COUNT(*) FROM Employee WHERE ID_Emp = '{employee.ID_Emp}'";
                    using (SqlCommand command = new SqlCommand(checkSql, connection))
                    {
                        if (connection.State != System.Data.ConnectionState.Open)
                            connection.Open();

                        int count = (int)command.ExecuteScalar();

                        if (count == 0)
                        {
                            errorMessage = $"Сотрудник '{employee.LName} {employee.Name} {employee.Pat}' не существует в базе данных или был удалён!";
                            return false;
                        }
                    }
                }

                // Проверяем на дубликаты
                var duplicates = team.GroupBy(x => x.ID_Emp)
                                    .Where(g => g.Count() > 1)
                                    .Select(g => g.First())
                                    .FirstOrDefault();

                if (duplicates != null)
                {
                    errorMessage = $"Сотрудник '{duplicates.LName} {duplicates.Name} {duplicates.Pat}' добавлен в команду более одного раза!";
                    return false;
                }

                return true;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public static bool ValidateProjectResponsible(string responsibleId, SqlConnection connection, out string errorMessage)
        {
            errorMessage = string.Empty;

            // Если ответственный не выбран - это допустимо
            if (string.IsNullOrEmpty(responsibleId) || responsibleId == DBNull.Value.ToString())
            {
                return true;
            }

            try
            {
                string checkSql = "SELECT COUNT(*) FROM Employee WHERE ID_Emp = @EmpId";
                using (SqlCommand command = new SqlCommand(checkSql, connection))
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                        connection.Open();

                    command.Parameters.AddWithValue("@EmpId", responsibleId);
                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        errorMessage = "Выбранный ответственный не существует в базе данных или был удалён!";
                        return false;
                    }
                }
                return true;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public static bool IsValidSkillLevel(string skillLevel)
        {
            if (!int.TryParse(skillLevel, out int level))
                return false;
            
            return level >= 1 && level <= 10;
        }

        public static bool ValidateReportOverdueParams(DateTime startDate, DateTime endDate, string employeeId, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (endDate <= startDate)
            {
                errorMessage = "Дата окончания должна быть позже даты начала";
                return false;
            }

            if (string.IsNullOrEmpty(employeeId) || employeeId == DBNull.Value.ToString())
            {
                errorMessage = "Необходимо выбрать сотрудника";
                return false;
            }

            return true;
        }
    }
} 