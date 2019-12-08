using System;
using System.Collections.Generic;
using System.Text;

namespace AvorionXMLToSTL
{
	class Class2
	{
		void rotate(
			)
		{ }
		/*{
			for (int i = 0; i < 8; i++)
			{
				if (block.look == 0)
				{
					switch (block.up)
					{
						case 3:
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationY((float)(1 * Math.PI / 2.0), avarage));
							continue;
						case 5:
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationZ((float)(3 * Math.PI / 2.0), avarage));
							continue;
						case 2:
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationX((float)(1 * Math.PI / 2.0), avarage));
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationY((float)(1 * Math.PI / 2.0), avarage));
							continue;
						case 4:
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationX((float)(2 * Math.PI / 2.0), avarage));
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationZ((float)(1 * Math.PI / 2.0), avarage));
							continue;
					}
				}
				else if (block.look == 1)
				{
					switch (block.up)
					{
						case 5:
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationZ((float)(1 * Math.PI / 2.0), avarage));
							continue;
						case 3:
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationY((float)(3 * Math.PI / 2.0), avarage));
							continue;
						default:
							continue;
					}
				}
				else if (block.look == 2)
				{
					switch (block.up)
					{
						case 0:
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationY((float)(3 * Math.PI / 2.0), avarage));
							break;
						case 1:
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationY((float)(1 * Math.PI / 2.0), avarage));
							break;
						case 2:
							continue;
						case 3:
							continue;
						case 4:
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationY((float)(2 * Math.PI / 2.0), avarage));
							break;
						case 5:
							//vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationY((float)(0 * Math.PI / 2.0), avarage));
							continue;
					}
				}
				else if (block.look == 3)
				{
					vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationX((float)(1 * Math.PI / 2.0), avarage));
					if (block.up == 0)
					{
						vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationY((float)(3 * Math.PI / 2.0), avarage));
						continue;
					}
					else if (block.up == 1)
					{
						vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationY((float)(1 * Math.PI / 2.0), avarage));
						continue;
					}
					else if (block.up == 5)
					{
						continue;
					}
					else if (block.up == 4)
					{
						vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationY((float)(2 * Math.PI / 2.0), avarage));
						continue;
					}
					else if (block.up == 2)
					{
						continue;
					}
					else if (block.up == 3)
					{
						continue;
					}
				}
				else if (block.look == 4)
				{
					switch (block.up)
					{
						case 0:
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationZ((float)(1 * Math.PI / 2.0), avarage));
							continue;
						case 1:
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationZ((float)(3 * Math.PI / 2.0), avarage));
							continue;
						case 2:
							vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationZ((float)(2 * Math.PI / 2.0), avarage));
							continue;
						default:
							continue;
					}
				}
				else if (block.look == 5)
				{
					vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationY((float)(2 * Math.PI / 2.0), avarage));
					if (block.up == 0)
					{
						//vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationX((float)(3 * Math.PI / 2.0), avarage));
						vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationY((float)(1 * Math.PI / 2.0), avarage));


						vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationX((float)(3 * Math.PI / 2.0), avarage));
						continue;
					}
					else if (block.up == 1)
					{
						vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationZ((float)(3 * Math.PI / 2.0), avarage));
						continue;
					}
					else if (block.up == 5)
					{

						continue;
					}
					else if (block.up == 4)
					{

						continue;
					}
					else if (block.up == 2)
					{
						vectors[i] = Vector3.Transform(vectors[i], Matrix4x4.CreateRotationZ((float)(2 * Math.PI / 2.0), avarage));
						continue;
					}
					else if (block.up == 3)
					{
						continue;
					}
				}
			}
			*/
	}
}
