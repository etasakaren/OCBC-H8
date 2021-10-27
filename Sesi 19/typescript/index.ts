const message: string = "Hello, it's me"
console.log(message)

function greetParticipant(name: string, age?: number) {
    console.log(`Hello, ${name}. You are ${age} y. o`)
}

let students: any[] = [
    ['Gusti', true, ['FSD', 'OCBC']],
    ['Ricky', true, ['FSD', 'OCBC']],
]

interface StudentObject {
    name: string;
    age: number | string;
    score: number;
}

let student: {
    name: string;
    age: number | string;
    score: number
} = {
    name: "Budi",
    age: 17,
    score: 100
}

greetParticipant("Aeta", 21)