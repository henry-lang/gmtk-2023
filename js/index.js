const canvas = document.getElementById("canvas");
const ctx = canvas.getContext("2d");

let width = undefined;
let height = undefined;

function resizeCanvas() {
    width = window.innerWidth;
    height = window.innerHeight;
    canvas.width = width;
    canvas.height = height;
}

function mainLoop() {
    ctx.clearRect(0, 0, width, height);
    ctx.fillStyle = "#ff0000"
    ctx.fillRect(0, 0, width, height);
    window.requestAnimationFrame(mainLoop);
}

window.addEventListener("resize", resizeCanvas);
resizeCanvas();
mainLoop();