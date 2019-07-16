The Contoso Analysis Platform (CAP) stores log files in fixed-size structures called
"Nodes", but each instance of the CAP uses different settings to optimize how the 
incoming logs are stored in each of the nodes. 

To handle transforming the incoming nodes, there is a frontend called the
Gateway that Outputs Written Nodes (GOWN). Its job is to take the incoming nodes
and rewrite them into the format expected by the CAP. To accomplish this, it needs to
take in a collection of incoming nodes and repartition them into nodes having the expected number of slots. 
In addition, some CAP instances want empty slots to be removed from Nodes; other instances, however, expect
these empty entries to be preserved as they are used during analysis.

Can you help us get the CAP & GOWN working together?