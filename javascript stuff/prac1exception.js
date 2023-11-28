function addTwoNumbers(number1, number2) {
  if (typeof number2 !== typeof 1 || typeof number1 !== typeof 1) {
    const error = new Error("Type is not int");
    throw error;
  }
  return number1 + number2;
}
try {
  console.log(addTwoNumbers(5, "nm"));
} catch (error) {
  console.log(error);
}
