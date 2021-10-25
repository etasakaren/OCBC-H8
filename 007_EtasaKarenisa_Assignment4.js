const readline = require("readline");
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question("Insert any number: ", function (num1) {
    rl.question("Insert another number: ", function (num2) {
        rl.question("Choose an option [+, -, *, /, %, ++, --]: ", function (option) {
            let number1 = parseInt(num1);
            let number2 = parseInt(num2);
            if (option == "+") {
                console.log(number1 + " + " + number2 + " =", number1 + number2);
            } else if (option == "-") {
                console.log(number1 + " - " + number2 + " =", number1 - number2);
            } else if (option == "*") {
                console.log(number1 + " * " + number2 + " =", number1 * number2);
            } else if (option == "/") {
                console.log(number1 + " / " + number2 + " =", number1 / number2);
            } else if (option == "%") {
                console.log(number1 + " % " + number2 + " =", number1 % number2);
            } else if (option == "++") {
                console.log(number1 + " => " + ++number1);
                console.log(number2 + " => " + ++number2);
            } else if (option == "--") {
                console.log(number1 + " => " + --number1);
                console.log(number2 + " => " + --number2);
            } else {
                console.log("Your option is not available.");
            }
            rl.close();
        });
    });
});

rl.on("close", function () {
    process.exit(0);
});