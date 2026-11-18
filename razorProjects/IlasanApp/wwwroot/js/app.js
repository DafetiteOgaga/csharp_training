console.log("Hey from TS in Razor Pages");
const indexTableHead = document.getElementsByClassName("index-table-head");
if (indexTableHead !== null) {
    Array.from(indexTableHead).forEach(ele => {
        const element = ele;
        element.style.backgroundColor = "whitesmoke";
    });
}
export {};
//# sourceMappingURL=app.js.map