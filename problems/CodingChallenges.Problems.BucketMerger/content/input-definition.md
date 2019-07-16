An input file for this problem will contain one header line, followed by a set of input *Node*s. The header line will contain an integer specifying how many slots each output node should contain, 
followed by a colon, and a flag indicating whether or not empty slots should be removed.

Each individual input *Node* will consist of a number of "slots", where each slot is separated from the next slot by a newline (any empty slots will also be on their own line). 
Each *Node* will begin with a \[ and end with a \]. A pair of these brackets will also enclose the full set of given input nodes and the brackets will always be on their own lines (which may also contain whitespace). For example, 
the following *Node* contains *m* slots:

    [
        Line 1
        Line 2
        ...
        Line m
    ]

Further, if the input contained *N* individual *Node* objects, they would be given in the the following format, where each *Node* would consist of *m+2* lines of the format given above:

    [
        Node 1
        Node 2
        ...
        Node N
    ]

Because the set of input nodes may contain whitespace for readability in a text editor, any of the following would be valid input strings (where \n and \t represent a newline and tab, respectively): 

    2:True\n[\n[\nA\n\B\n\n]\n[\n\n\nC\n]\n]

    2:True\n[\n  [\n    A\n    B\n    \n    ]\n  [\n    \n    \n    C\n  ]\n]

    2:True\n[\n\t[\n\tA\n\tB\n\t\n\t]\n\t[\n\t\n\t\n\tC\n\t]\n]

