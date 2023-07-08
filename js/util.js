class Vec2 {
    constructor (x, y) {
        this.x = x;
        this.y = y;
    }

    dot (b) {
        return new Vec2 (this.x * b.x, this.y * b.y);
    }

    magnitude () {
        return Math.sqrt(this.x * this.x + this.y * this.y);
    }
}
