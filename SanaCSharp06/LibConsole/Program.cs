using Library;

Human human1= new Human("Oleg","Olehao",new DateOnly(2003,12,3));
Human human2 = new Human("Max", "Kaneki", new DateOnly(2004, 11, 17));
Human human3 = new Human("Yulian", "Akerman", new DateOnly(1965,7,16));

Applicant applicant1 = new Applicant(human1,1,12,"School1");

LibUser libUser1 = new LibUser(human2,1, new DateOnly(2023, 1, 22),993);

Professor professor1 = new Professor(human3, "Lector", "Department1", "National Technical University of Ukraine“Igor Sikorsky Kyiv Polytechnic Institute”");

human1.ShowInfo();
human2.ShowInfo();
human3.ShowInfo();
applicant1.ShowInfo();
professor1.ShowInfo();
libUser1.ShowInfo();


