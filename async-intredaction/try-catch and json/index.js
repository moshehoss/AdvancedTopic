//ex1
// function TimeOutDemo(x) {
//   const t = setTimeout(() => {
//     console.log(`after ${x} seconds`);
//     clearTimeout(t);
//   }, x * 1000);
// }

// TimeOutDemo(3);

//ex2
//dif page

//ex3
function SumNum(x, y) {
  try {
    if (typeof x != "number" || typeof y != "number") {
      const NotNumError = new Error("one or more werent numbers!");
      throw NotNumError;
    } else {
      return x + y;
    }
  } catch (error) {
    console.log(error);
  }
}

// SumNum("h", 2);

// ex4
let x = -3;
function NegtiveNum(x) {
  if (x < 0) {
    const NotNumError = new Error("negetive number!");
    throw NotNumError;
  }
}

// try {
//   NegtiveNum(x);
// } catch (error) {
//   console.log(error);
//   x = 0;
// } finally {
//   console.log(x);
// }
