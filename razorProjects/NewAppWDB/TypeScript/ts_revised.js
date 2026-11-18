let studentName: string = "john";
let studentAge: number = 23;

console.log(studentName);
console.log(studentAge);

let isRegistered: boolean = true;
let hasPaid: boolean = false;

console.log(isRegistered);
console.log(hasPaid);

let studentInfo: any = "John";

studentInfo = 20;
studentInfo = true;
studentInfo = { name: "John", age: 20 };

let schoolName = "Totalman Schools";
// schoolName = 45; // not allowed

// arrays
let students: string[] = ["John", "Mary", "Peter"];
let ages: number[] = [18, 20, 22];
let attendance: boolean[] = [true, false, true];

students.push("Grace");
console.log(students);

let studentsArray = [
    { name: "John", age: 20 },
    { name: "Mary", age: 22 },
    { name: "Peter", age: 19 }
];
studentsArray.push({ name: "Grace", age: 21 }); // Allowed
// studentsArray.push({ name: "James", age: "twenty" }); // Error

// explicitly defined types
let student: {
    name: string;
    age: number;
    isRegistered: boolean;
} = {
    name: "John",
    age: 20,
    isRegistered: true
};

// interface
interface IStudent {
    name: string;
    age: number;
    department: string;
}

let studentOne: IStudent = {
    name: "John",
    age: 20,
    department: "Computer Science"
};

let studentTwo: IStudent = {
    name: "Mary",
    age: 22,
    department: "Mathematics"
};

// flexible interface
interface IStudent2 {
    name: string;
    age: number;
    department?: string;
}
let studentOne1: IStudent2 = {
    name: "John",
    age: 20,
    department: "Computer Science"
};

let studentTwo1: IStudent2 = {
    name: "Mary",
    age: 22
};

// readonly interface
interface IStudent3 {
    readonly id: number;
    name: string;
    age: number;
    department?: string;
}
let studentOne2: IStudent3 = {
    id: 1,
    name: "John",
    age: 20
};

studentOne2.name = "James"; // Allowed
// studentOne2.id = 5; // Error

// array of objects
interface IStudent4 {
    readonly id: number;
    name: string;
    age: number;
    department?: string;
}

let studentsOne3: IStudent4[] = [
    {
        id: 1,
        name: "John",
        age: 20,
        department: "Computer Science"
    },
    {
        id: 2,
        name: "Mary",
        age: 22
    }
];
studentsOne3.push({
    id: 3,
    name: "Peter",
    age: 19
});
console.log(`Array of objs: ${studentsOne3}`);

// functions
function greetMe(name: string): string {
	return `Hello ${name}`;
}

console.log(greetMe("dafe"));

function autoGreet(): void {
	console.log("Yo!, whats up");
}

function displayStudent(name: string, age: number): void {
	console.log(`Hey, ${name}. I can see that you are ${age}years old.`);
}
displayStudent("jane", 23);

// optional function parameters
function greetStudent(name: string, department?: string): void {
    console.log(`Welcome, ${name}`);

    if (department) {
        console.log(`Department: ${department}`);
    }
}
greetStudent("Isabella");
greetStudent("Ishola", "chemistry");

// default parameters
function registerStudent(
    name: string,
    age: number,
    department: string = "Undecided"
): void {
    console.log(`Name: ${name}`);
    console.log(`Age: ${age}`);
    console.log(`Department: ${department}`);
}
registerStudent("John", 20);
registerStudent("Mary", 22, "Mathematics");

let redNum: number[] = [1, 2, 3, 4, 5];
let finSum: number = redNum.reduce((tot, cur)=>tot+cur, 0)
console.log(`final sum: ${finSum}`)

function addPlusTen(...nums: number[]): number {
	return (nums.reduce((total, current)=>total+current, 5))/nums.length
}
console.log(`AVG = ${addPlusTen(1, 2, 3, 4, 5)}`);

// union types
let studentId: number | string;

studentId = 101;       // Valid
studentId = "STU101";  // Also valid

function displayStudentId(val: number|string): void {
	console.log(`you entered: ${val}`);
}
displayStudentId(101);
displayStudentId("STU2026");

// type aliases
type StudentId = number | string;

let studentId1: StudentId = 101;

studentId1 = "STU2026";


type TStudent = {
    id: number;
    name: string;
    age: number;
};

let studenttp: TStudent = {
    id: 1,
    name: "John",
    age: 20
};

type TTeacher = {
	id: number;
	name: string;
	subject: string;
}

let teacher: TTeacher = {
	id: 3,
	name: "femi",
	subject: "bio"
}
console.log(`teacher: ${teacher}`);

// generics
function getValue<T>(value: T): T {
    return value;
}
console.log(
    `for generic number: ${getValue<number>(100)}\n`,
    `for generic string: ${getValue<string>("english texts")}`
)

console.log(
    `for inferred generic number: ${getValue(100)}\n`,
    `for inferred generic string: ${getValue("english texts")}`
)


// promise
async function getStudentAge(): Promise<number> {
    return 20;
}
async function displayPromiseValue1(): Promise<void> {
    let ret1: number = await getStudentAge();
    console.log(`async number: ${ret1}`);
}
displayPromiseValue1();

interface IPromiseStudent {
    id: number;
    name: string;
    age: number;
}
async function getStudentDetails(): Promise<IPromiseStudent> {
    return {
        id: 2,
        name: "manfreddy",
        age: 43
    };
}
async function displayStudentDetails(): Promise<void> {
    let retVar: IPromiseStudent = await getStudentDetails();
    console.log(`async classwork: ${JSON.stringify(retVar)}`);
}
displayStudentDetails();
