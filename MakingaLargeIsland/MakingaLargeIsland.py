from typing import List

def largestIsland( grid: List[List[int]]) -> int:
    directions = [(1,0),(0,1),(0,-1),(-1,0)]
    area = [1]
    dict_ = {}
    id_ = [2]
    xlimit = len(grid) - 1
    ylimit = len(grid[0]) - 1
	
    def helper(grid, id_, x, y):
        for direction in directions:
            x_ = x + direction[0]
            y_ = y + direction[1]
            if x_ >= 0 and x_ <= xlimit and y_ >= 0 and y_ <= ylimit and grid[x_][y_] == 1:
                area[0] = area[0] + 1
                grid[x_][y_] = id_[0]
                helper(grid, id_, x_, y_)
            
    
    for i in range(len(grid)):
        for j in range(len(grid[0])):
            if grid[i][j] == 1:
                grid[i][j] = id_[0]
                helper(grid, id_, i, j)
                dict_[id_[0]] = area[0]
                area[0] = 1
                id_[0] += 1
    
    if len(dict_) == 0:
        return 1
    maxArea = 0
    area_ = 1
    find = False
    for i in range(len(grid)):
        for j in range(len(grid[0])):
            if grid[i][j] == 0:
                find = True
                neighbors = set()
                area_ = 1
                for direction in directions:
                    x_ = i + direction[0]
                    y_ = j + direction[1]
                    if x_ >= 0 and x_ <= xlimit and y_ >= 0 and y_ <= ylimit and grid[x_][y_] != 0:
                        neighbors.add(grid[x_][y_])
                for n in neighbors:
                    area_ += dict_[n]
                maxArea = max(maxArea, area_)
    if(find == False):
        return dict_[2]
    return maxArea
grid = [[1,1,1],[1,0,1],[1,1,1]]
a = largestIsland(grid)

