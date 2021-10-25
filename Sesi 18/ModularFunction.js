function removeSpaces(text){
    return text.replace(' ', '');
}

function reverseText(text){
    return text.split("").reverse().join("");
}

function updateVowels(text){
    const mapper = {
        a: 'b', e: 'f', i: 'j', o: 'p', u: 'v',
        A: 'B', E: 'F', I: 'J', O: 'P', U: 'V'
      }
    return text.replace(/[aeiou]/gi, match => mapper[match])
}

let password = 'dimitri w';
let noSpaces = removeSpaces(password);
let reversed = reverseText(noSpaces);
let encryptedPassword = updateVowels(reversed);

console.log(noSpaces);
console.log(reversed);
console.log(encryptedPassword);