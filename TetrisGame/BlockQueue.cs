namespace TetrisGame;

public class BlockQueue
{
    private readonly Block[] blocks = new Block[]
    {
        new BlockI(),
        new BlockJ(),
        new BlockL(),
        new BlockO(),
        new BlockS(),
        new BlockT(),
        new BlockZ()
    };

    private readonly Random random = new Random();
    
    public Block NextBlock { get; private set; }

    public BlockQueue()
    {
        NextBlock = RandomBlock();
    }

    private Block RandomBlock()
    {
        return blocks[random.Next(blocks.Length)];
    }

    public Block GetAndUpdate()
    {
        Block block = NextBlock;

        do
        {
            NextBlock = RandomBlock();
        } while (block.Id == NextBlock.Id);

        return block;
    }
}
//Autor: Kosmita