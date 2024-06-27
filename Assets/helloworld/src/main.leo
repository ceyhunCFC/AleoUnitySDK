program helloworld.aleo {

    struct Row {
        c1: u8,
        c2: u8,
        c3: u8
    }

    struct Board {
        r1: Row,
        r2: Row,
        r3: Row,
    }

    transition main(public a: u8, b: u8, c: u8, d: u8, e: u8, f: u8, g: u8, h: u8, i: u8)
    -> Board {
       
       return Board {
            r1: Row { c1: a, c2: b, c3: c },
            r2: Row { c1: d, c2: e, c3: f },
            r3: Row { c1: g, c2: h, c3: i },
        };
    }

}















