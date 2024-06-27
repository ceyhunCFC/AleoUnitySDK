program helloworld.aleo;

struct Row:
    c1 as u8;
    c2 as u8;
    c3 as u8;

struct Board:
    r1 as Row;
    r2 as Row;
    r3 as Row;


function main:
    input r0 as u8.public;
    input r1 as u8.private;
    input r2 as u8.private;
    input r3 as u8.private;
    input r4 as u8.private;
    input r5 as u8.private;
    input r6 as u8.private;
    input r7 as u8.private;
    input r8 as u8.private;
    cast r0 r1 r2 into r9 as Row;
    cast r3 r4 r5 into r10 as Row;
    cast r6 r7 r8 into r11 as Row;
    cast r9 r10 r11 into r12 as Board;
    output r12 as Board.private;
