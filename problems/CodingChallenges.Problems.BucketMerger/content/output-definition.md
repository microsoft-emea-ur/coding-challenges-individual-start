Your output should have four header lines, followed by the expected set of output *Node*s. More specifically, your output should be:

* _int_ *OutputNodeCount*
* _int_ *NodeCountDifference*
* _int_ *EmptySlotDifference*
* _int_ *EmptySlotCount*
* _Node\[\]_ *OutputNodes*

Where:

+ OutputNodeCount is the total number of *Node*s written to *OutputNodes*.
+ *NodeCountDifference* is the difference between the count of *Node*s in the given input and correct output. This number should be positive if there are more *Node*s in *OutputNodes* than in *InputNodes*, and should
be negative if there are fewer.
+ *EmptySlotDifference* is the difference between the combined number of empty slots across all of the *Node*s in *InputNodes* and *OutputNodes*. This number should be positive if there are more empty slots in all of the *Node*s in *OutputNodes* than in *InputNodes*, and should be negative if there are fewer.
+ *EmptySlotCount* is the total number of empty slots contained across all of the *Node*s in *OutputNodes*.
+ *OutputNodes* is the resulting set of output *Node*s.

It is noted that _all_ output nodes should remove leading and trailing whitespace from each line. For example, if an input slot contained "  demo\\t", the corresponding
output slot should just be "demo" in the output node.