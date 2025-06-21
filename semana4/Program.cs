// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Agenda agenda = new Agenda(8);

Paciente paciente1 = new Paciente("1234567890", "LUCIA", "BRAVO", "lucia.bravo@uea.com", "0987654321");
Paciente paciente2 = new Paciente("224578158", "MARIA", "CARDOZO", "mariacardozo@uea,edu.com", "223145356");
Paciente paciente3 = new Paciente("175486754", "CRISTIAN", "MENESES", "cristianmeneses@uea.edu.com", "0993516891");


Doctor doctor1 = new Doctor("CARLOS", "ODONTOLOGIA");
Doctor doctor2 = new Doctor("BETY", "GINECOLOGIA");
Doctor doctor3 = new Doctor("KARLA", "CARDIOLOGO");


Turno turno1 = new Turno(paciente1, doctor1, "2025-06-20 18:50");
Turno turno2 = new Turno(paciente2, doctor2, "2025-06-25 13:30");
Turno turno3 = new Turno(paciente3, doctor3, "2025-07-30 10:00");


turno1.Mostrar();
turno2.Mostrar();
turno3.Mostrar();






