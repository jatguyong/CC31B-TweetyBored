import java.util.Scanner;

class TreeNode {
int data;
TreeNode left, right;

TreeNode(int value) {
data = value;
}
}

public class BinarySearchTree {
private TreeNode root;

// Insertion method
private TreeNode insert(TreeNode root, int value) {
if (root == null)
return new TreeNode(value);

if (value < root.data)
root.left = insert(root.left, value);
else if (value > root.data)
root.right = insert(root.right, value);

return root;
}

public void insert(int value) {
root = insert(root, value);
}

// Deletion method
private TreeNode delete(TreeNode root, int value) {
if (root == null)
return null;

if (value < root.data)
root.left = delete(root.left, value);
else if (value > root.data)
root.right = delete(root.right, value);
else {
// Node with no child or only one child
if (root.left == null)
return root.right;
else if (root.right == null)
return root.left;

// Node with two children
root.data = minValue(root.right); // Get the inorder successor
root.right = delete(root.right, root.data); // Delete the inorder successor
}

return root;
}

private int minValue(TreeNode root) {
int minVal = root.data;
while (root.left != null) {
minVal = root.left.data;
root = root.left;
}
return minVal;
}

public void delete(String values) {
String[] deleteValues = values.split(",");
for (String value : deleteValues)
root = delete(root, Integer.parseInt(value.trim()));
}

// Traversal methods
private void preorder(TreeNode root) {
if (root != null) {
System.out.print(root.data + " ");
preorder(root.left);
preorder(root.right);
}
}

private void inorder(TreeNode root) {
if (root != null) {
inorder(root.left);
System.out.print(root.data + " ");
inorder(root.right);
}
}

private void postorder(TreeNode root) {
if (root != null) {
postorder(root.left);
postorder(root.right);
System.out.print(root.data + " ");
}
}

public void printTraversals() {
System.out.print("Preorder: ");
preorder(root);
System.out.println();

System.out.print("Inorder: ");
inorder(root);
System.out.println();

System.out.print("Postorder: ");
postorder(root);
System.out.println();
}

// Display the tree as a 1D array
private void displayArray(TreeNode root, int[] arr, int index) {
if (root != null) {
displayArray(root.left, arr, index * 2 + 1);
arr[index] = root.data;
displayArray(root.right, arr, index * 2 + 2);
}
}

public void printArrayRepresentation() {
int height = getHeight(root);
int size = (int) Math.pow(2, height) - 1;
int[] arr = new int[size];
displayArray(root, arr, 0);

System.out.print("1D Array: ");
for (int value : arr)
System.out.printf("%-4d", value);

System.out.println();

System.out.print("Index: ");
for (int i = 0; i < size; i++)
System.out.printf("%-4d", i);

System.out.println();
}

// Insert: 50, 60, 80, 40, 45, 30
// Delete 40, 50
// Insert: 20, 35, 40, 33, 70, 90, 37
//

// Get the height of the tree
private int getHeight(TreeNode root) {
if (root == null)
return 0;

int leftHeight = getHeight(root.left);
int rightHeight = getHeight(root.right);

return Math.max(leftHeight, rightHeight) + 1;
}

public static void main(String[] args) {
BinarySearchTree bst = new BinarySearchTree();
@SuppressWarnings("resource")
Scanner scanner = new Scanner(System.in);

while (true) {
System.out.println("\nOptions:");
System.out.println("1. Add integers");
System.out.println("2. Delete integers");
System.out.println("3. Create a new tree");
System.out.println("4. Exit");
System.out.print("Choose an option: ");

int choice = scanner.nextInt();
scanner.nextLine();

switch (choice) {
case 1:
System.out.print("Integers separated by commas, no spaces ('exit' to quit): ");
String addInput = scanner.nextLine().trim();

if (addInput.equalsIgnoreCase("exit"))
System.exit(0);

for (String value : addInput.split(","))
bst.insert(Integer.parseInt(value.trim()));

bst.printArrayRepresentation();
bst.printTraversals();
break;

case 2:
System.out.print("Integers separated by commas to delete: ");
bst.delete(scanner.nextLine().trim());
bst.printArrayRepresentation();
bst.printTraversals();
break;

case 3:
bst = new BinarySearchTree();
System.out.println("New tree created.");
break;

case 4:
System.out.println("Exiting program.");
System.exit(0);

default:
System.out.println("Invalid choice. Please enter a valid option.");
}
}
}
}