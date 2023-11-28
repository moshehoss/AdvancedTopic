function checkNumber(num) {
  if (num < 0) {
    const error = new Error("Number is negative");
    throw error;
  }
  return num;
}
let num = 14;
try {
  checkNumber(num);
} catch (error) {
  num = 0;
  console.log(error);
} finally {
  console.log(num);
}
