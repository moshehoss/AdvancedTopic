const URL = "https://jsonplaceholder.typicode.com/posts/1";
/*PRACTICE 3*/
async function getTitle() {
  let data = await fetch(URL, {
    method: "GET",
    //body: { title: "myTitle" },
  });
  let jsonData = await data.json();
  console.log(jsonData["title"]);
}
getTitle();
/*PRACTICE 4*/
async function deleteTitle() {
  let data = await fetch(URL, {
    method: "DELETE",
  });
  if (data["status"] == 200) {
    console.log("Deletion successful");
  }
}
deleteTitle();
